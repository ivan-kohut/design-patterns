using System;

namespace Decorator
{
  public class FileDataSource : IDataSource
  {
    private readonly string filename;

    public FileDataSource(string filename)
    {
      this.filename = filename;
    }

    public void WriteData(string data) => Console.WriteLine($"Write '{data}' to '{filename}' file");

    public string ReadData()
    {
      Console.WriteLine($"Read data from '{filename}' file");

      return DateTimeOffset.UtcNow.ToString();
    }
  }
}
