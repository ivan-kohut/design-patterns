using System;
using System.Collections.Generic;

namespace Visitor
{
  public class Program
  {
    static void Main(string[] args)
    {
      List<Shape> shapes = new List<Shape> { new Circle(), new Rectangle() };

      IExportVisitor exportVisitor = new ExcelExportVisitor();
      shapes.ForEach(s => s.Accept(exportVisitor));

      Console.WriteLine("------------------------");

      exportVisitor = new CsvExportVisitor();
      shapes.ForEach(s => s.Accept(exportVisitor));
    }
  }
}
