using System;

namespace Decorator
{
  public class EncryptionDecorator : DataSourceDecorator
  {
    public EncryptionDecorator(IDataSource dataSource) : base(dataSource)
    {
    }

    public override void WriteData(string data)
    {
      Console.WriteLine($"Encrypt input data: {data}");

      base.WriteData(data + " - " + data);
    }

    public override string ReadData()
    {
      string result = base.ReadData();

      Console.WriteLine($"Decrypt output data: {result}");

      return result;
    }
  }
}
