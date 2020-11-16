using GodelTech.StoryLine.Exceptions;
using GodelTech.StoryLine.Expectations;
using GodelTech.StoryLine.Tests.Helpers;
using System;
using Xunit;

namespace GodelTech.StoryLine.Tests.Expectations
{
    public class LazyExpectationTwoParametersTests
    {
        private readonly LazyExpectation<ExpectationBuilder, TestAction, TestAction> _underTest;

        public LazyExpectationTwoParametersTests()
        {
            _underTest = new LazyExpectation<ExpectationBuilder, TestAction, TestAction>();
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
