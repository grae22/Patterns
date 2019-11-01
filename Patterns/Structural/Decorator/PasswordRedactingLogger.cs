namespace Patterns.Structural.Decorator
{
  internal class PasswordRedactingLogger : LoggerDecorator
  {
    public PasswordRedactingLogger(in ILogger logger)
    :
      base(in logger)
    {
    }

    public override void Log(in string message)
    {
      // Redaction logic...

      base.Log(message);
    }
  }
}
