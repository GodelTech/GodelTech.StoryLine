using GodelTech.StoryLine.Services;
using System;
using Xunit;

namespace GodelTech.StoryLine.Tests.Services
{
    public class ScenarioRunnerTests
    {
        private readonly ScenarioRunner _underTest;

        public ScenarioRunnerTests()
        {
            _underTest = new ScenarioRunner();
        }

        [Fact]
        public void Run_WhenContextIsNull_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _underTest.Run(null, 0, 0, false));
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(5, 0)]
        public void Run_WhenAttemptsCountIsNull_ShouldThrowArgumentOutOfRangeException(int attemptsCount, int millisecondsTimeout)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _underTest.Run(new ScenarioContext(), attemptsCount, millisecondsTimeout, false));
        }

        [Fact]
        public void Run_ShouldExecuteWithoutExceptions()
        {
            _underTest.Run(new ScenarioContext(), 5, 10, false);
        }
    }
}
