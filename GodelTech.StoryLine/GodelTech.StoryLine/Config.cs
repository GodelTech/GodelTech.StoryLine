using System;
using GodelTech.StoryLine.Contracts;
using GodelTech.StoryLine.Services;

namespace GodelTech.StoryLine
{
    public static class Config
    {
        private static Func<IScenarioRunner> _createScenarioRunner = () => new ScenarioRunner();

        public static Func<IScenarioRunner> CreateScenarioRunner
        {
            get => _createScenarioRunner;
            set => _createScenarioRunner = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
