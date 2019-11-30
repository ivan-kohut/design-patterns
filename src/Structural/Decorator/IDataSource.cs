namespace Decorator
{
  public interface IDataSource
  {
    void WriteData(string data);
    string ReadData();
  }
}
