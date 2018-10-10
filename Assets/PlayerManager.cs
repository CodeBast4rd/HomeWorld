using UnityEditor;

namespace Assets {
  public class PlayerManager : SpawnHelper {
    public PlayerCamera PlayerCamera;
    public PlayerInput PlayerInput;

    public PlayerManager() : base(@"Assets\HomeWorld\Player.obj") {
      this.PlayerCamera = new PlayerCamera();
      this.PlayerInput = new PlayerInput();
    }

    public void ReadyPlayer() {
      this.PlayerCamera.Setup();
    }
  }
}