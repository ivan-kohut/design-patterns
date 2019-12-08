namespace State
{
  public class Player
  {
    private IState state;

    public Player()
    {
      this.state = new ReadyState(this);
    }

    public void ChangeState(IState state) => this.state = state;

    public void ClickLock() => state.ClickLock();
    public void ClickNext() => state.ClickNext();
    public void ClickPlay() => state.ClickPlay();
    public void ClickPrevious() => state.ClickPrevious();
  }
}
