using System.Security.Cryptography;

namespace Patterns.Behavioural.Command.Commands
{
  internal class MoveBackward : ICommand
  {
    private readonly IPlayer _player;

    public MoveBackward(in IPlayer player)
    {
      _player = player;
    }

    public void Execute()
    {
      _player.MoveBackward();
    }

    public void Undo()
    {
      _player.MoveForward();
    }
  }
}
