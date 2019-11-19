namespace Patterns.Behavioural.ChainOfResponsibility
{
  internal class SecurityHeaderValidator : RequestHandler
  {
    public SecurityHeaderValidator(in IRequestHandler nextHandler)
    :
      base(nextHandler)
    {
    }

    public override object ProcessAndReturnResponse(in object request)
    {
      // Validate the request's headers...

      return PassRequestToNextHandler(request);
    }
  }
}
