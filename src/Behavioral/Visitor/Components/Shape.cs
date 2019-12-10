namespace Visitor
{
  public abstract class Shape
  {
    public abstract void Accept(IExportVisitor exportVisitor);
  }
}
