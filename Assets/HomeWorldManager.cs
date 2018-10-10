namespace Assets
{
  public class HomeWorldManager {
    private PlayerManager _playerManager;

    public void Instantiate(SacredGrove sacredGrove) {
      this._playerManager = new PlayerManager();
      this._playerManager.ReadyPlayer();
      sacredGrove.Instantiate(this._playerManager);
    }
  }
}