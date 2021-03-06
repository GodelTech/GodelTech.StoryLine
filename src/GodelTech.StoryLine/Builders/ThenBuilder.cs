﻿using System;
using GodelTech.StoryLine.Contracts;
using GodelTech.StoryLine.Expectations;

namespace GodelTech.StoryLine.Builders
{
    public class ThenBuilder : BuilderBase
    {
        public ThenBuilder(IScenarioContext context)
            : base(context)
        {
        }

        public ThenBuilder Expects<TBuilder>(Action<TBuilder> config = null)
            where TBuilder : IExpectationBuilder, new()
        {
            var builder = new TBuilder();

            config?.Invoke(builder);

            Context.AddExpectation(builder.Build());

            return this;
        }

        public ThenBuilder Expects<TBuilder, TArtifact1>(
            Action<TBuilder, TArtifact1> config = null,
            Func<TArtifact1, bool> artifact1Filter = null
            )
            where TBuilder : IExpectationBuilder, new()
        {
            Context.AddExpectation(new LazyExpectation<TBuilder, TArtifact1>(config, artifact1Filter));

            return this;
        }

        public ThenBuilder Expects<TBuilder, TArtifact1, TArtifact2>(
            Action<TBuilder, TArtifact1, TArtifact2> config = null,
            Func<TArtifact1, bool> artifact1Filter = null,
            Func<TArtifact2, bool> artifact2Filter = null
            )
            where TBuilder : IExpectationBuilder, new()
        {
            Context.AddExpectation(new LazyExpectation<TBuilder, TArtifact1, TArtifact2>(config, artifact1Filter, artifact2Filter));

            return this;
        }

        public ThenBuilder Expects<TBuilder, TArtifact1, TArtifact2, TArtifact3>(
            Action<TBuilder, TArtifact1, TArtifact2, TArtifact3> config = null,
            Func<TArtifact1, bool> artifact1Filter = null,
            Func<TArtifact2, bool> artifact2Filter = null,
            Func<TArtifact3, bool> artifact3Filter = null
        )
            where TBuilder : IExpectationBuilder, new()
        {
            Context.AddExpectation(new LazyExpectation<TBuilder, TArtifact1, TArtifact2, TArtifact3>(
                config,
                artifact1Filter,
                artifact2Filter,
                artifact3Filter));

            return this;
        }

        public ThenBuilder Then(IActor actor)
        {
            Context.CurrentActor = actor ?? throw new ArgumentNullException(nameof(actor));

            return this;
        }

        public void Run(int attemptsCount = 1, int millisecondsTimeout = 1000, bool cleanActorsOnRetry = true)
        {
            if (attemptsCount <= 0)
                throw new ArgumentOutOfRangeException(nameof(attemptsCount));
            if (millisecondsTimeout <= 0)
                throw new ArgumentOutOfRangeException(nameof(millisecondsTimeout));

            Config.CreateScenarioRunner().Run(Context, attemptsCount, millisecondsTimeout, cleanActorsOnRetry);
        }
    }
}
