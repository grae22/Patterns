namespace Patterns.Behavioural.ChainOfResponsibility
{
  internal interface IRequestHandler
  {
    object ProcessAndReturnResponse(in object request);
  }
}
