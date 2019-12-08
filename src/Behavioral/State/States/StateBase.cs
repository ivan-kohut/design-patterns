namespace State
{
  public abstract class StateBase : IState
  {
    protected readonly Player player;

    protected StateBase(Player player)
    {
      this.player = player;
    }

    public abstract void ClickLock();
    public abstract void ClickNext();
    public abstract void ClickPlay();
    public abstract void ClickPrevious();
  }
}
