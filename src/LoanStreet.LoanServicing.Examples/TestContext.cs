using System;
using System.IO;
using Newtonsoft.Json;

namespace LoanStreet.LoanServicing.Examples
{
    public class TestContext
    {

        public  TestContext() {}
        
        public TestContext(string username, string password, string institutionId)
        {
            this.username = username;
            this.password = password;
            this.institutionId = institutionId;
        }
        
        public string username
        {
            get;
            set;
        }

        public string password
        {
            get;
            set;
        }

        public string institutionId
        {
            get;
            set;
        }


        public bool IsValid()
        {
            return !String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password) &&
                   !String.IsNullOrEmpty(institutionId);
        }
        
        
        public static TestContext FromEnvVars()
        {
            var envVars = Environment.GetEnvironmentVariables();

            if (
                envVars.Contains(nameof(username))
                && envVars.Contains(nameof(password))
                && envVars.Contains(nameof(institutionId))
            )
            {
                var context = new TestContext(
                        username: envVars[nameof(username)].ToString(),
                        password: envVars[nameof(password)].ToString(),
                        institutionId: envVars[nameof(institutionId)].ToString()
                    );
                
                return context;
            }

            return null;

        }
        public static TestContext FromFile(string file)
        {
            var workingDirectory = Directory.GetCurrentDirectory();
            var projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            var contextFile = Path.Combine(projectDirectory, file);
            var rawContext = File.ReadAllText(contextFile);

            var context = JsonConvert.DeserializeObject<TestContext>(rawContext);

            return context;
        }
        
        public static TestContext LoadContext()
        {
            var context = FromEnvVars();

            if (context != null)
                return context;

            context = FromFile("test_context.json");
            
            if (context == null || !context.IsValid())
                throw new Exception("Failed to load a valid test context!");

            return context;
        }
    }
}