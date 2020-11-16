using GodelTech.StoryLine.Services;
using GodelTech.StoryLine.Tests.Helpers;
using System;
using Xunit;

namespace GodelTech.StoryLine.Tests.Services
{
    public class ScenarioContextTests
    {
        private readonly ScenarioContext _underTest;
        private readonly TestAction _action;
        private readonly Expectation _expectation;

        public ScenarioContextTests()
        {
            _underTest = new ScenarioContext();
            _action = new TestAction();
            _expectation = new Expectation();
        }

        [Fact]
        public void AddAction_WhenNullIsSent_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _underTest.AddAction(null));
        }

        [Fact]
        public void AddAction_WhenActionIsSent_ShouldAddAction()
        {
            _underTest.AddAction(_action);
        }

        [Fact]
        public void AddExpectation_WhenNullIsSent_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _underTest.AddExpectation(null));
        }

        [Fact]
        public void AddExpectation_WhenExpectationIsSent_ShouldAddExpectation()
        {
            _underTest.AddExpectation(_expectation);
        }
    }
}
