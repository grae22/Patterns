namespace Patterns.Behavioural.ChainOfResponsibility
{
  internal class BetHandler : RequestHandler
  {
    public BetHandler(in IRequestHandler nextHandler)
    :
      base(nextHandler)
    {
    }

    public override object ProcessAndReturnResponse(in object request)
    {
      var requestAsString = request as string;

      if (!requestAsString.Contains("bet"))
      {
        return PassRequestToNextHandler(request);
      }

      // Do some processing...

      return "bet response";
    }
  }
}
