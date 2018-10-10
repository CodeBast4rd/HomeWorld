using UnityEngine;

namespace Assets
{
  public interface ISpawn {
    GameObject SpawnAt(float x, float y, float z);
    GameObject Spawn();
  }
}