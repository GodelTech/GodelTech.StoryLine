namespace GodelTech.StoryLine.Contracts
{
    public interface IScenarioAction
    {
        IActor Actor { get; }
        IAction Action { get; }

        void Execute();
    }
}
