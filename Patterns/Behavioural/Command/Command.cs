namespace Patterns.Behavioural.Command
{
  internal abstract class Command : ICommand
  {
    private readonly CommandHistory _commandHistory;

    protected Command(in CommandHistory commandHistory)
    {
      _commandHistory = commandHistory;
    }

    public void Execute()
    {
      ExecuteCommand();

      _commandHistory.Push(this);
    }

    public void Undo()
    {
      UndoCommand();
    }

    protected abstract void ExecuteCommand();
    protected abstract void UndoCommand();
  }
}
