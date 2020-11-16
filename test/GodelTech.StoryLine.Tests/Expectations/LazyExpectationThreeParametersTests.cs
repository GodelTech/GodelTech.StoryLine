using GodelTech.StoryLine.Exceptions;
using GodelTech.StoryLine.Expectations;
using GodelTech.StoryLine.Tests.Helpers;
using System;
using Xunit;

namespace GodelTech.StoryLine.Tests.Expectations
{
    public class LazyExpectationThreeParametersTests
    {
        private readonly LazyExpectation<ExpectationBuilder, TestAction, TestAction, TestAction> _underTest;

        public LazyExpectationThreeParametersTests()
        {
            _underTest = new LazyExpectation<ExpectationBuilder, TestAction, TestAction, TestAction>();
        }

        [Fact]
        public void Validate_WhenActorIsNull_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _underTest.Validate(null));
        }

        [Fact]
        public void Validate_WhenActorIsNull_ShouldThrowExpectationException()
        {
            Assert.Throws<ExpectationException>(() => _underTest.Validate(new Actor()));
        }
    }
}
