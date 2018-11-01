using System.Collections.Generic;
using System.Linq;

namespace Patterns.Creational.ObjectPool
{
  internal class ThreadPool
  {
    private readonly Stack<Thread> _availableThreads = new Stack<Thread>();
    private readonly List<Thread> _allocatedThreads = new List<Thread>();

    public ThreadPool(int maxThreadCount)
    {
      for (var i = 0; i < maxThreadCount; i++)
      {
        _availableThreads.Push(new Thread());
      }
    }

    public Thread AcquireThread()
    {
      if (!_availableThreads.Any())
      {
        return null;
      }

      Thread thread = _availableThreads.Pop();

      _allocatedThreads.Add(thread);

      return thread;
    }

    public void ReleaseThread(Thread thread)
    {
      if (!_allocatedThreads.Contains(thread))
      {
        return;
      }

      _allocatedThreads.Remove(thread);
      _availableThreads.Push(thread);
    }
  }
}
