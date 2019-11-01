namespace Patterns.Structural.Decorator
{
  internal abstract class LoggerDecorator : ILogger
  {
    private readonly ILogger _logger;

    protected LoggerDecorator(in ILogger logger)
    {
      _logger = logger;
    }

    public virtual void Log(in string message)
    {
      _logger.Log(message);
    }
  }
}
