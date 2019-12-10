using System;

namespace Visitor
{
  public class CsvExportVisitor : IExportVisitor
  {
    public void Visit(Circle circle) => Console.WriteLine($"{nameof(circle)} in {nameof(CsvExportVisitor)}");

    public void Visit(Rectangle rectangle) => Console.WriteLine($"{nameof(rectangle)} in {nameof(CsvExportVisitor)}");
  }
}
