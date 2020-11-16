using FakeItEasy;
using FluentAssertions;
using GodelTech.StoryLine.Services;
using GodelTech.StoryLine.Tests.Helpers;
using System;
using Xunit;

namespace GodelTech.StoryLine.Tests.Services
{
    public class ArtifactCollectionTests
    {
        private readonly ArtifactCollection _underTest;
        private readonly TestAction[] _actionList;

        public ArtifactCollectionTests()
        {
            _underTest = new ArtifactCollection();
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
                } };
        }

        [Fact]
        public void Add_WhenNullIsSent_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _underTest.Add(null));
        }

        [Fact]
        public void Add_WhenActionSent_ShouldAddArtifact()
        {
            _underTest.Add(_actionList[0]);
        }

        [Fact]
        public void GetAll_WhenPredicateIsNull_ShouldReturnAllArtifacts()
        {
            AddArtifactsToCollection();
           _underTest.GetAll<TestAction>().Should().BeEquivalentTo(new[] { _actionList[1], _actionList[0] });
        }

        [Fact]
        public void GetAll_WhenPredicateIsNotNull_ShouldReturnFilteredArtifacts()
        {
            AddArtifactsToCollection();
            _underTest.GetAll<TestAction>((x) => x.User.LastName == "Doe").Should().BeEquivalentTo(new[] { _actionList[0], _actionList[1] });
        }

        [Fact]
        public void GetAll_WhenNoResult_ShouldReturnNull()
        {
            AddArtifactsToCollection();
            _underTest.GetAll<TestAction>((x) => x.User.LastName == "John").Should().BeEmpty();
        }

        [Fact]
        public void Get_WhenPredicateIsNull_ShouldReturnFirstArtifact()
        {
            AddArtifactsToCollection();
            _underTest.Get<TestAction>().Should().BeSameAs(_actionList[1]);
        }

        [Fact]
        public void Get_WhenPredicateIsNotNull_ShouldReturnFirstArtifact()
        {
            AddArtifactsToCollection();
            _underTest.Get<TestAction>((x) => x.User.LastName == "Doe").Should().BeEquivalentTo(_actionList[1]);
        }

        [Fact]
        public void Get_WhenNoResult_ShouldReturnNull()
        {
            AddArtifactsToCollection();
            _underTest.Get<TestAction>((x) => x.User.LastName == "John").Should().BeNull();
        }

        private void AddArtifactsToCollection()
        {
            foreach (var action in _actionList)
            {
                _underTest.Add(action);
            }
        }
    }
}
