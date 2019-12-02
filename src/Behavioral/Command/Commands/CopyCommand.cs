using System;

namespace Command
{
  public class CopyCommand : CommandBase
  {
    public CopyCommand(Editor editor) : base(editor)
    {
    }

    public override void Execute() => Console.WriteLine($"Just copying text: {editor.Text}");
  }
}
