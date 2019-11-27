namespace Patterns.Behavioural.Command
{
  internal class ButtonHandler : IButtonHandler
  {
    private readonly ICommand _moveForward;
    private readonly ICommand _moveBackward;

    public ButtonHandler(
      in ICommand moveForward,
      in ICommand moveBackward)
    {
      _moveForward = moveForward;
      _moveBackward = moveBackward;
    }

    public void OnButtonPress(string button)
    {
      switch (button)
      {
        case "up":
          _moveForward.Execute();
          break;

        case "down":
          _moveBackward.Execute();
          break;
      }
    }
  }
}
