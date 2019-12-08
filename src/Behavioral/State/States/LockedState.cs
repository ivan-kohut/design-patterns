using System;

namespace State
{
  public class LockedState : StateBase
  {
    public LockedState(Player player) : base(player)
    {
    }

    public override void ClickLock() => player.ChangeState(new ReadyState(player));

    public override void ClickNext() => Console.WriteLine("Nothing");

    public override void ClickPlay() => Console.WriteLine("Nothing");

    public override void ClickPrevious() => Console.WriteLine("Nothing");
  }
}
