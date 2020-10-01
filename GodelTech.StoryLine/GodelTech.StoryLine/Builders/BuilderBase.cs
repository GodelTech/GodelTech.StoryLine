using System;
using GodelTech.StoryLine.Contracts;

namespace GodelTech.StoryLine.Builders
{
    public abstract class BuilderBase
    {
        public IScenarioContext Context { get; }

        protected BuilderBase(IScenarioContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
