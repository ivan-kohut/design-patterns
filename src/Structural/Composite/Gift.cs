using System;

namespace Composite
{
  public abstract class Gift
  {
    public abstract bool IsBox { get; }
    public abstract void Show();

    public virtual void Add(Gift gift) => throw new NotImplementedException();
    public virtual void Remove(Gift gift) => throw new NotImplementedException();
  }
}
