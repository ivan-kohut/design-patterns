namespace Decorator
{
  public class DataSourceDecorator : IDataSource
  {
    private readonly IDataSource dataSource;

    public DataSourceDecorator(IDataSource dataSource)
    {
      this.dataSource = dataSource;
    }

    public virtual void WriteData(string data) => dataSource.WriteData(data);

    public virtual string ReadData() => dataSource.ReadData();
  }
}
