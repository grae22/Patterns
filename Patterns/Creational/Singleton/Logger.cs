using System;

namespace Patterns.Creational.Singleton
{
  internal class Logger : ILogger
  {
    public static ILogger Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new Logger();
        }

        return _instance;
      }
    }

    private static ILogger _instance;

    private Logger()
    {
    }

    public static void SetLogger(ILogger logger)
    {
      RaiseExceptionIfAttemptingToOverwriteExistingInstance();

      _instance = logger;
    }

    public void Log(string message)
    {
    }

    private static void RaiseExceptionIfAttemptingToOverwriteExistingInstance()
    {
      if (_instance == null)
      {
        return;
      }

      throw new NotSupportedException(
        "Logger instance already exists - the logger can only be set if not already instantiated. " +
        "The 'set' method should only be used to facilitate unit-testing.");
    }
  }
}
