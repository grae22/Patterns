using NUnit.Framework;

using Patterns.Behavioural.ChainOfResponsibility;

namespace PatternsTests.Behavioural.ChainOfResponsibility
{
  [TestFixture]
  public class Client
  {
    [TestCase("bet request", "bet response")]
    [TestCase("win request", "win response")]
    public void Test(in string request, in string expectedResponse)
    {
      var winHandler = new WinHandler(null);
      var betHandler = new BetHandler(winHandler);
      var securityHeaderValidator = new SecurityHeaderValidator(betHandler);

      var response = securityHeaderValidator.ProcessAndReturnResponse(request) as string;

      Assert.AreEqual(response, expectedResponse);
    }
  }
}
