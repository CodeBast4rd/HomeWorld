using UnityEditor;
using UnityEngine;

namespace Assets
{
  public class SpawnHelper : ISpawn {
    private readonly GameObject _spawnTemplate;

    public SpawnHelper(string spawnAssetPath) {
      this._spawnTemplate = AssetDatabase.LoadAssetAtPath<GameObject>(spawnAssetPath);
    }

    public GameObject SpawnAt(float x, float y, float z) {
      GameObject spawnedObject = Object.Instantiate(this._spawnTemplate, new Vector3(x, y, z), new Quaternion());
      return spawnedObject;
    }

    public GameObject Spawn() {
      return this.SpawnAt(0, 0, 0);
    }
  }
}