using GodelTech.StoryLine.Exceptions;
using GodelTech.StoryLine.Expectations;
using GodelTech.StoryLine.Tests.Helpers;
using System;
using Xunit;

namespace GodelTech.StoryLine.Tests.Expectations
{
    public class LazyExpectationOneParameterTests
    {
        private readonly LazyExpectation<ExpectationBuilder, TestAction> _lazyExpectation;

        public LazyExpectationOneParameterTests()
        {
            _lazyExpectation = new LazyExpectation<ExpectationBuilder, TestAction>();
        }

        [Fact]
        public void Validate_WhenActorIsNull_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _lazyExpectation.Validate(null));
        }

        [Fact]
        public void Validate_WhenActorIsNull_ShouldThrowExpectationException()
        {
            Assert.Throws<ExpectationException>(() => _lazyExpectation.Validate(new Actor()));
        }
    }
}
