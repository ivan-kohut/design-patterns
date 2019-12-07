using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Observer
{
  public class Subject
  {
    private readonly IList<IObserver> observers;

    public Subject()
    {
      this.observers = new List<IObserver>();
      this.State = string.Empty;
    }

    public string State { get; private set; }

    public void Subscribe(IObserver observer) => observers.Add(observer);

    public void Unsubscribe(IObserver observer) => observers.Remove(observer);

    public void Notify()
    {
      foreach (IObserver observer in observers)
      {
        observer.Update(State);
      }
    }

    public async Task DoImportantWorkAsync()
    {
      State = DateTimeOffset.UtcNow.ToString();

      await Task.Delay(5000);

      Notify();
    }
  }
}
