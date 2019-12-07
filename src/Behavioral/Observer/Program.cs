using System.Threading.Tasks;

namespace Observer
{
  public class Program
  {
    static async Task Main(string[] args)
    {
      IObserver consoleObserver = new ConsoleObserver();
      IObserver fileObserver = new FileObserver();

      Subject subject = new Subject();

      subject.Subscribe(consoleObserver);
      subject.Subscribe(fileObserver);

      await subject.DoImportantWorkAsync();

      subject.Unsubscribe(fileObserver);

      await subject.DoImportantWorkAsync();
    }
  }
}
