namespace Visitor
{
  public class Circle : Shape
  {
    public override void Accept(IExportVisitor exportVisitor) => exportVisitor.Visit(this);
  }
}
