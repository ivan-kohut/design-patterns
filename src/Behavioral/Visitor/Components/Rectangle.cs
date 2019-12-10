namespace Visitor
{
  public class Rectangle : Shape
  {
    public override void Accept(IExportVisitor exportVisitor) => exportVisitor.Visit(this);
  }
}
