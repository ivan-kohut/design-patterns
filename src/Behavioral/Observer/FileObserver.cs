using System;

namespace Observer
{
  public class FileObserver : IObserver
  {
    public void Update(string state) => Console.WriteLine($"File has got state: {state}");
  }
}
