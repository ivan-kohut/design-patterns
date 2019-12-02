using System;

namespace Command
{
  public class CutCommand : CommandBase
  {
    public CutCommand(Editor editor) : base(editor)
    {
    }

    public override void Execute()
    {
      Console.WriteLine($"Just cutting text: {editor.Text}");

      editor.Text = string.Empty;
    }
  }
}
