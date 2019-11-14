using System;

namespace Composite
{
  public class Product : Gift
  {
    public string Name { get; set; }

    public Product(string name)
    {
      this.Name = name;
    }

    public override bool IsBox => false;

    public override void Show() => Console.WriteLine($"{nameof(Product)}: {Name}");
  }
}
