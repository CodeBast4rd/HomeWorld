using UnityEngine;

namespace Assets
{
  public class PlayerCamera {
    public Camera Camera { get; set; }

    public PlayerCamera() {
      this.Camera = new Camera();
    }

    public void Setup() {
    }
  }
}