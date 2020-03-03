using FlubuCore.Context;
using FlubuCore.Scripting;

using System;
using System.IO;
using FlubuCore.Tasks.Versioning;

namespace BuildScript
{
    public class BuildScript : DefaultBuildScript
    {
        private const string ProjectNamespace = "LoanStreet.LoanServicing";
        private const string SourceFolder = "src";
        private const string PackagesFolder = "packages";

        private const string SolutionFile = "LoanStreet.LoanServicing.sln";

        private readonly static string ClientProject =  Path.Combine(SourceFolder, "LoanStreet.LoanServicing", "LoanStreet.LoanServicing.csproj");

        private readonly static string TestProject = Path.Combine(SourceFolder, "LoanStreet.LoanServicing.Test", "LoanStreet.LoanServicing.Test.csproj");

        private readonly static string ExamplesProject = Path.Combine(SourceFolder, "LoanStreet.LoanServicing.Examples", "LoanStreet.LoanServicing.Examples.csproj");

        private const string Company = "LoanStreet, Inc.";

        private readonly static string NuGetKeyPrefix = "NuGetAPIKey";

        [FromArg("NuGetAPIKey")]
        public string NuGetAPIKey { get; set; }

        private string NugetPackageName(IBuildPropertiesContext context)
        {
            return $"{ProjectNamespace}.{context.Properties.GetBuildVersionWithQuality().BuildVersionWithQuality(3)}.nupkg";
        }

        protected override void ConfigureBuildProperties(IBuildPropertiesContext context)
        {
            context.Properties.Set(BuildProps.CompanyName, Company);
            context.Properties.Set(BuildProps.CompanyTrademark, "2020");
            context.Properties.Set(BuildProps.ProductId, "LoanStreet.LoanServicing");
            context.Properties.Set(BuildProps.ProductName, "LoanStreet LoanServicing API Client");

            context.Properties.Set(BuildProps.SolutionFileName, SolutionFile);
            context.Properties.Set(BuildProps.Solution, SolutionFile);
        }

        protected override void ConfigureTargets(ITaskContext context)
        {

            var buildVersion = context.CreateTarget("build.version")
                .SetAsHidden()
                .AddTask(x => x.FetchBuildVersionFromFileTask());

            var nuget = context.CreateTarget("nuget.restore")
                .SetDescription("ReInstall Nuget Packages")
                .AddCoreTask(x => x.Restore().Force());

            var clean = context.CreateTarget("clean")
                .SetDescription("Clean Solution")
                .DependsOn(buildVersion)
                .AddCoreTask(x => x.Clean())
                .AddTask(x => x.DeleteDirectoryTask(PackagesFolder, false));

            var debugBuild = context.CreateTarget("build.debug")
                .SetDescription("Initiate a Debug Build")
                .DependsOn(buildVersion)
                .AddCoreTask(x => x.Build(SolutionFile).Configuration("Debug"));

            var releaseBuild = context.CreateTarget("build.release")
                .SetDescription("Initiate a Release Build")
                .DependsOn(buildVersion)
                .AddCoreTask(x =>
                    x.UpdateNetCoreVersionTask(
                        "src/LoanStreet.LoanServicing/LoanStreet.LoanServicing.csproj")) //// Task get's version from context.Properties.Get<Version>(BuildProps.BuildVersion) and updates version in csproj
                .AddCoreTask(x => x.Restore())
                .AddCoreTask(x => x.Build(SolutionFile).Configuration("Release"));


            var package = context.CreateTarget("nuget.package")
                .SetDescription("Assemble Nuget Package")
                .DependsOn(releaseBuild)
                .AddCoreTask(x => x
                    .Pack()
                    .Project(ClientProject)
                    .Configuration("Release")
                    .OutputDirectory(PackagesFolder)
                );


            var nugetPush = context.CreateTarget("nuget.publish")
                .SetDescription("Publishes nuget package.")
                .Do(NugetPublish)
                .DependsOn(package);

            var generatedTests = context.CreateTarget("run.tests")
                .SetDescription("Execute Generated Unit Tests")
                .DependsOn(debugBuild)
                .AddCoreTask(x => x.Test().Project(TestProject));

            var exampleTests = context.CreateTarget("run.examples")
                .SetDescription("Execute the Example Tests")
                .DependsOn(debugBuild)
                .AddCoreTask(x => x.Test().Project(ExamplesProject));

        }

        private void NugetPublish(ITaskContext context)
        {
            context.CoreTasks().NugetPush(
                    Path.Combine(PackagesFolder, NugetPackageName(context)))
                .ServerUrl("https://www.nuget.org/api/v2/package")
                .ApiKey(NuGetAPIKey).Execute(context);

        }
    }
}
