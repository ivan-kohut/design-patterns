namespace Visitor
{
  public interface IExportVisitor
  {
    void Visit(Circle circle);
    void Visit(Rectangle rectangle);
  }
}
