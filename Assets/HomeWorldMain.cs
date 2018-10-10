using System.Collections;
using System.Threading;
using UnityEngine;

namespace Assets {
  public class HomeWorldMain : MonoBehaviour {
    public HomeWorldManager HomeWorldManager { get; set; }

    // Use this for initialization
    void Start() {
      this.SetupGame();
    }

    // Update is called once per frame
    void Update() {

    }

    private void SetupGame() {
      this.HomeWorldManager = new HomeWorldManager();
      SacredGrove sacredGrove = new SacredGrove();
      this.HomeWorldManager.Instantiate(sacredGrove);
    }
  }
}