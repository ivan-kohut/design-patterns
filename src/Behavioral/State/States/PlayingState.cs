using System;

namespace State
{
  public class PlayingState : StateBase
  {
    public PlayingState(Player player) : base(player)
    {
    }

    public override void ClickLock() => player.ChangeState(new LockedState(player));

    public override void ClickNext() => Console.WriteLine("Next track..");

    public override void ClickPlay()
    {
      Console.WriteLine("Stop playing..");

      player.ChangeState(new ReadyState(player));
    }

    public override void ClickPrevious() => Console.WriteLine("Previous track..");
  }
}
