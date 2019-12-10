using System;

namespace Visitor
{
  public class ExcelExportVisitor : IExportVisitor
  {
    public void Visit(Circle circle) => Console.WriteLine($"{nameof(circle)} in {nameof(ExcelExportVisitor)}");

    public void Visit(Rectangle rectangle) => Console.WriteLine($"{nameof(rectangle)} in {nameof(ExcelExportVisitor)}");
  }
}
