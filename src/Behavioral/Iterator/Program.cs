using System;

namespace Iterator
{
  public class Program
  {
    static void Main(string[] args)
    {
      IIterableCollection<int> intCollection = new IterableList<int>();

      intCollection.Add(1);
      intCollection.Add(2);
      intCollection.Add(3);

      foreach (int item in intCollection)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine("-------------");

      IIterableCollection<string> stringCollection = new IterableList<string>();

      stringCollection.Add("first");
      stringCollection.Add("second");
      stringCollection.Add("third");

      foreach (string item in stringCollection)
      {
        Console.WriteLine(item);
      }
    }
  }
}
