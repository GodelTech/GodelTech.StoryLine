using GodelTech.StoryLine.Contracts;
using GodelTech.StoryLine.Services;

namespace GodelTech.StoryLine
{
    public class Actor : IActor
    {
        public IArtifactCollection Artifacts { get; } = new ArtifactCollection();
    }
}
