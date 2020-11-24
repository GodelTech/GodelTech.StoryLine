using GodelTech.StoryLine.Services;
using GodelTech.StoryLine.Tests.Helpers;
using Xunit;

namespace GodelTech.StoryLine.Tests.Services
{
    public class ScenarioActionTests
    {
        private readonly ScenarioAction _underTest;
        
        public ScenarioActionTests()
        {
            _underTest = new ScenarioAction(new Actor(), new TestAction());
        }

        [Fact]
        public void Excecute_ShouldNotThrowException()
        {
            _underTest.Execute();
        }
    }
}
