using Xunit;

namespace SonarQubeDotNetCoreCodeCoverageExample.Test
{
    public class ExampleTest
    {
        [Fact]
        public void TestExampleClass_ExampleMethod()
        {
            var result = new ExampleClass().ExampleMethod();

            Assert.True(result);
        }
    }
}
