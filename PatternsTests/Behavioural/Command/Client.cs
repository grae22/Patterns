using NSubstitute;

using NUnit.Framework;

using Patterns.Behavioural.Command;
using Patterns.Behavioural.Command.Commands;

namespace PatternsTests.Behavioural.Command
{
  [TestFixture]
  public class Client
  {
    [Test]
    public void Test()
    {
      var player = Substitute.For<IPlayer>();

      var moveForwardComment = new MoveForward(player);
      var moveBackwardComment = new MoveBackward(player);

      var buttonHandler = new ButtonHandler(
        moveForwardComment,
        moveBackwardComment);

      var game = new Game(buttonHandler);

      game.OnButtonPress("up");
      game.OnButtonPress("up");
      game.OnButtonPress("down");

      game.UndoLastMove();
    }
  }
}
