﻿using System;
using GodelTech.StoryLine.Contracts;

namespace GodelTech.StoryLine.Builders
{
    public class ScenarioBuilder : BuilderBase
    {
        public ScenarioBuilder(IScenarioContext context)
            : base(context)
        {
        }

        public GivenBuilder Given()
        {
            return Given(Context.CurrentActor);
        }

        public GivenBuilder Given(IActor actor)
        {
            Context.CurrentActor = actor ?? throw new ArgumentNullException(nameof(actor));

            return new GivenBuilder(Context);
        }

        public WhenBuilder When()
        {
            return When(Context.CurrentActor);
        }

        public WhenBuilder When(IActor actor)
        {
            Context.CurrentActor = actor ?? throw new ArgumentNullException(nameof(actor));

            return new WhenBuilder(Context);
        }
    }
}
