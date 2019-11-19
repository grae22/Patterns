namespace Patterns.Behavioural.ChainOfResponsibility
{
  internal abstract class RequestHandler : IRequestHandler
  {
    private readonly IRequestHandler _nextHandler;

    protected RequestHandler(in IRequestHandler nextHandler)
    {
      _nextHandler = nextHandler;
    }

    public abstract object ProcessAndReturnResponse(in object request);

    protected object PassRequestToNextHandler(in object request)
    {
      return _nextHandler?.ProcessAndReturnResponse(request);
    }
  }
}
