using System.Collections.Generic;
using System.Linq;

namespace Memento
{
  public class Caretaker
  {
    private readonly IList<IMemento> mementos;

    public Caretaker()
    {
      this.mementos = new List<IMemento>();
    }

    public void AddMemento(IMemento memento) => mementos.Add(memento);

    public void Undo()
    {
      if (mementos.Count == 0)
      {
        return;
      }

      IMemento lastMemento = mementos.Last();

      mementos.Remove(lastMemento);

      lastMemento.Restore();
    }
  }
}
