using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using TryGitHubAction;
using Program = TryGitHubAction.Program;

namespace TestTryGitHubAction
{
    public class UnitTest1
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            int result = Program.Add(5, 7);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Add_NegativeAndPositive_ReturnsCorrect()
        {
            int result = Program.Add(-3, 8);
            Assert.Equal(5, result);
        }
    }
}