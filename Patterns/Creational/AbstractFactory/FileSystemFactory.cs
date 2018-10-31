namespace Patterns.Creational.AbstractFactory
{
  internal class FileSystemFactory : ILoggerFactory
  {
    public ILogger CreateLogger()
    {
      return new FileLogger();
    }
  }
}
