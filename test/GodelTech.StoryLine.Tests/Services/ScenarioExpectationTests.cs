using GodelTech.StoryLine.Services;
using GodelTech.StoryLine.Tests.Helpers;
using Xunit;

namespace GodelTech.StoryLine.Tests.Services
{
    public class ScenarioExpectationTests
    {
        private readonly ScenarioExpectation _underTest;

        public ScenarioExpectationTests()
        {
            _underTest = new ScenarioExpectation(new Actor(), new Expectation());
        }

        [Fact]
        public void Validate_ShouldNotThrowException()
        {
            _underTest.Validate();
        }
    }
}
