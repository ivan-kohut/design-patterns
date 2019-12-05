namespace Memento
{
  public class Program
  {
    static void Main(string[] args)
    {
      Caretaker caretaker = new Caretaker();

      IOriginator originator = new Originator(1, "Simple text");

      caretaker.AddMemento(originator.Save());

      for (int i = 0; i < 2; i++)
      {
        originator.ResetValues();
        caretaker.AddMemento(originator.Save());
      }

      originator.ResetValues();

      for (int i = 0; i < 3; i++)
      {
        originator.ShowValues();
        caretaker.Undo();
      }

      originator.ShowValues();
    }
  }
}
