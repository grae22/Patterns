namespace Patterns.Behavioural.Command.Commands
{
  internal class MoveForward : ICommand
  {
    private readonly IPlayer _player;

    public MoveForward(in IPlayer player)
    {
      _player = player;
    }

    public void Execute()
    {
      _player.MoveForward();
    }

    public void Undo()
    {
      _player.MoveBackward();
    }
  }
}