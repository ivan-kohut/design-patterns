using System;

namespace Decorator
{
  public class Program
  {
    static void Main(string[] args)
    {
      IDataSource fileDataSource = new FileDataSource("test-file.txt");
      IDataSource encryptedDataSource = new EncryptionDecorator(fileDataSource);

      string data = encryptedDataSource.ReadData();

      Console.WriteLine();

      encryptedDataSource.WriteData(data);
    }
  }
}
