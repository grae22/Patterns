using System.Linq;

namespace Patterns.Behavioural.Command
{
  internal class Game
  {
    private readonly IButtonHandler _buttonHandler;
    private readonly CommandHistory _commandHistory = new CommandHistory();

    public Game(
      in IButtonHandler buttonHandler)
    {
      _buttonHandler = buttonHandler;
    }

    public void OnButtonPress(string button)
    {
      _buttonHandler.OnButtonPress(button);
    }

    public void UndoLastMove()
    {
      if (!_commandHistory.Any())
      {
        return;
      }

      _commandHistory
        .Pop()
        .Execute();
    }
  }
}
