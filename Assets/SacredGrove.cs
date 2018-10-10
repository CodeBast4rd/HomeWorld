namespace Assets
{
  public class SacredGrove {
    public GroveMobManager GroveMobManager { get; set; }
    public GroveAreaManager GroveAreaManager { get; set; }
    public PlayerManager PlayerManager { get; set; }

    public void Instantiate(PlayerManager playerManager) {
      this.GroveAreaManager = new GroveAreaManager();
      this.GroveAreaManager.SetupLevel();
      this.GroveMobManager = new GroveMobManager();
      this.GroveMobManager.SpawnEnemy();
      this.PlayerManager = playerManager;
      this.PlayerManager.SpawnAt(0, 0, 0);
    }
  }
}