using System;
using System.Collections;
using System.Collections.Generic;

namespace Composite
{
  public class Box : Gift, IEnumerable<Gift>
  {
    private readonly IList<Gift> gifts;

    public Box()
    {
      this.gifts = new List<Gift>();
    }

    public override void Add(Gift gift) => gifts.Add(gift);
    public override void Remove(Gift gift) => gifts.Remove(gift);

    public override bool IsBox => true;

    public override void Show()
    {
      Console.WriteLine($"--- {nameof(Box)}: opening");

      foreach (Gift gift in gifts)
      {
        gift.Show();
      }

      Console.WriteLine($"--- {nameof(Box)}: closing");
    }

    public IEnumerator<Gift> GetEnumerator() => gifts.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  }
}
