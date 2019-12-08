using System;

namespace State
{
  public class ReadyState : StateBase
  {
    public ReadyState(Player player) : base(player)
    {
    }

    public override void ClickLock() => player.ChangeState(new LockedState(player));

    public override void ClickNext() => Console.WriteLine("Next track..");

    public override void ClickPlay()
    {
      Console.WriteLine("Start playing..");

      player.ChangeState(new PlayingState(player));
    }

    public override void ClickPrevious() => Console.WriteLine("Previous track..");
  }
}
