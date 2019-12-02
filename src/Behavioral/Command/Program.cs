using System;

namespace Command
{
  class Program
  {
    static void Main(string[] args)
    {
      Editor editor = new Editor
      {
        Text = "Hello!"
      };

      Button copyButton = new Button(new CopyCommand(editor));
      Button pasteButton = new Button(new PasteCommand(editor));
      Button cutButton = new Button(new CutCommand(editor));
      
      cutButton.Click();

      Console.WriteLine($"Current editor text is empty: {editor.Text.Length}");

      pasteButton.Click();

      Console.WriteLine($"Current editor text: {editor.Text}");

      copyButton.Click();
    }
  }
}
