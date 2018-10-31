namespace Patterns.Creational.AbstractFactory
{
  internal class ConsoleSystemFactory : ILoggerFactory
  {
    public ILogger CreateLogger()
    {
      return new ConsoleLogger();
    }
  }
}
