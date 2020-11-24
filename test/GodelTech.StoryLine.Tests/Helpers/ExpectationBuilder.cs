using GodelTech.StoryLine.Contracts;

namespace GodelTech.StoryLine.Tests.Helpers
{
    public class ExpectationBuilder : IExpectationBuilder
    {
        public IExpectation Build()
        {
            return new Expectation();
        }
    }
}
