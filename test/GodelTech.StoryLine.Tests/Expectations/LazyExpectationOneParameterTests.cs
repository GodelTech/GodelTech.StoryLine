using GodelTech.StoryLine.Exceptions;
using GodelTech.StoryLine.Expectations;
using GodelTech.StoryLine.Tests.Helpers;
using System;
using Xunit;

namespace GodelTech.StoryLine.Tests.Expectations
{
    public class LazyExpectationOneParameterTests
    {
        private readonly LazyExpectation<ExpectationBuilder, TestAction> _underTest;
        private readonly TestAction[] _actionList;

        public LazyExpectationOneParameterTests()
        {
            _underTest = new LazyExpectation<ExpectationBuilder, TestAction>();
            _actionList = new[] {
                new TestAction()
                {
                    User = new User()
                    {
                        FirstName = "John",
                        LastName = "Doe"
                    }
                }, new TestAction()
                {
                    User = new User()
                    {
                        FirstName = "Jane",
                        LastName = "Doe"
                    }
                }
            };
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

        [Fact]
        public void Validate_ShouldRunWithoutExceptions()
        {
            var actor = new Actor();
            AddArtifactsToCollection(actor);
            _underTest.Validate(actor);
        }

        private void AddArtifactsToCollection(Actor actor)
        {
            foreach (var action in _actionList)
            {
                actor.Artifacts.Add(action);
            }
        }
    }
}
