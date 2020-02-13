using FlubuCore.Context;
using FlubuCore.Scripting;

using System;
using System.IO;

namespace BuildScript
{
    public class BuildScript : DefaultBuildScript
    {
        
        private const string ProjectNamespace = "LoanStreet.LoanServicing";
        private const string SourceFolder = "src";
        
        
        private const string SolutionFile = "LoanStreet.LoanServicing.sln";

        private static string ClientProject =
            Path.Combine(SourceFolder, "LoanStreet.LoanServicing", "LoanStreet.LoanServicing.csproj");
        private static string TestProject = Path.Combine(SourceFolder, "LoanStreet.LoanServicing.Test", "LoanStreet.LoanServicing.Test.csproj");
        private static string ExamplesProject = Path.Combine(SourceFolder, "LoanStreet.LoanServicing.Examples", "LoanStreet.LoanServicing.Examples.csproj");

        private const string Company = "LoanStreet, Inc.";
            
        protected override void ConfigureBuildProperties(IBuildPropertiesContext context)
        {
            context.Properties.Set(BuildProps.CompanyName, Company);
            context.Properties.Set(BuildProps.CompanyTrademark, "2020");
            context.Properties.Set(BuildProps.ProductId, "LoanStreet.LoanServicing");
            context.Properties.Set(BuildProps.ProductName, "LoanStreet LoanServicing API Client");
            
            context.Properties.Set(BuildProps.SolutionFileName, SolutionFile);
            context.Properties.Set(BuildProps.Solution, SolutionFile);

            context.Properties.Set(BuildProps.BuildVersion, "0.0.9");
        }
        
        protected override void ConfigureTargets(ITaskContext context)
        {

            var clean = context.CreateTarget("clean")
                .SetDescription("Clean Solution")
                .AddCoreTask(x => x.Clean());
            
            var debugBuild = context.CreateTarget("build.debug")
                .SetDescription("Initiate a Debug Build")
                .AddCoreTask(x => x.Build(SolutionFile).Configuration("Debug"));

            var releaseBuild = context.CreateTarget("build.release")
                .SetDescription("Initiate a Release Build")
                .AddCoreTask(x => x.Build(SolutionFile).Configuration("Release"));

            var generatedTests = context.CreateTarget("run.tests")
                .SetDescription("Execute Generated Unit Tests")
                .DependsOn(debugBuild)
                .AddCoreTask(x => x.Test().Project(TestProject));

            var exampleTests = context.CreateTarget("run.examples")
                .SetDescription("Execute the Example Tests")
                .DependsOn(debugBuild)
                .AddCoreTask(x => x.Test().Project(ExamplesProject));

            var package = context.CreateTarget("create.package")
                .SetDescription("Assemble Nuget Package")
                .AddCoreTask(x => x.Pack().Project(ClientProject).Configuration("Release"));

        }
    }
}
