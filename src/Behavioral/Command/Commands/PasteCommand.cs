using System;

namespace Command
{
  public class PasteCommand : CommandBase
  {
    public PasteCommand(Editor editor) : base(editor)
    {
    }

    public override void Execute()
    {
      Console.WriteLine($"Just pasting text to editor..");

      editor.Text = DateTimeOffset.UtcNow.ToString();
    }
  }
}
