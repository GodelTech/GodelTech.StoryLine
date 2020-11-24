using GodelTech.StoryLine.Contracts;

namespace GodelTech.StoryLine.Tests.Helpers
{
    public class TestAction : IAction
    {
        public User User { get; set; }

        public void Execute(IActor actor)
        {
            actor.Artifacts.Add(new User
            {
                FirstName = "John",
                LastName = "Doe"
            });
        }
    }
}
