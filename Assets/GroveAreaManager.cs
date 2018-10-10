namespace Assets
{
  public class GroveAreaManager {
    public SunManager Sun { get; set; }
    public SacredGroveGround SacredGroveGround { get; set; }

    public void SetupLevel() {
      this.Sun = new SunManager();
      this.Sun.SunSet();
      this.SacredGroveGround = new SacredGroveGround();
      this.SacredGroveGround.SetGround();
    }
  }
}