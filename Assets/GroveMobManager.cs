using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
  public class GroveMobManager {
    public int GroveMobState { get; set; }

    public Skeleton Skeleton { get; set; }

    public Dictionary<int,GameObject> SkeletonMap { get; set; }

    public GroveMobManager() {
      this.Skeleton = new Skeleton();
      this.SkeletonMap = new Dictionary<int, GameObject>();
      this.GroveMobState = 0;
    }

    public void SpawnEnemy() {
      switch (this.GroveMobState) {
        case 0:
          this.SkeletonMap.Add(0,this.Skeleton.SpawnAt(0, 3f, -41f));
          this.SkeletonMap.Add(1,this.Skeleton.SpawnAt(-16, 3f, -41f));
          this.SkeletonMap.Add(2,this.Skeleton.SpawnAt(-32, 3f, -41f));
          break;
        default:
          break;
      }
    }
  }
}