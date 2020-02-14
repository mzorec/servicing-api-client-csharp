using System;
using Xunit;

namespace LoanStreet.LoanServicing.Examples
{
    public class TestBase
    {

        public static TestContext Context = null;
        
        public TestBase(string testContextFile = "test_context.json")
        {

            if (Context == null)
            {
                Context = TestContext.LoadContext();
                Assert.NotNull(Context);
                ClientFactory.SetCredentials(Context.username, Context.password);
                
            }
            
        }
        
    }
}