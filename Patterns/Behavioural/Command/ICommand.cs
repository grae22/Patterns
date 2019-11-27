namespace Patterns.Behavioural.Command
{
  internal interface ICommand
  {
    void Execute();
    void Undo();
  }
}
