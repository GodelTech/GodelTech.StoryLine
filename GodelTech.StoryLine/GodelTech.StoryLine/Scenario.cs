using GodelTech.StoryLine.Builders;
using GodelTech.StoryLine.Services;

namespace GodelTech.StoryLine
{
    public class Scenario
    {
        public static ScenarioBuilder New()
        {
            return new ScenarioBuilder(new ScenarioContext());
        }
    }
}
