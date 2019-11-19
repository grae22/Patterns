namespace Patterns.Behavioural.ChainOfResponsibility
{
  internal class WinHandler : RequestHandler
  {
    public WinHandler(in IRequestHandler nextHandler)
      :
      base(nextHandler)
    {
    }

    public override object ProcessAndReturnResponse(in object request)
    {
      var requestAsString = request as string;

      if (!requestAsString.Contains("win"))
      {
        return PassRequestToNextHandler(request);
      }

      // Do some processing...

      return "win response";
    }
  }
}
