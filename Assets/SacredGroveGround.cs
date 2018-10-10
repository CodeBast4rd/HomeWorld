using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Assets
{
  public class SacredGroveGround {

    public Dictionary<int, GameObject> Map;

    public void SetGround() {
      this.Map = new Dictionary<int, GameObject>();
      string objectPath = @"Assets\HomeWorld\SacredgroveArena.obj";
      GameObject sacredGroveAreana = AssetDatabase.LoadAssetAtPath<GameObject>(objectPath);
      this.Map.Add(0, Object.Instantiate(sacredGroveAreana, new Vector3(0f, 0f, 0f), new Quaternion()));
      this.Map.Add(1, Object.Instantiate(sacredGroveAreana, new Vector3(0f, 0f, 112f), new Quaternion()));
      this.Map.Add(2, Object.Instantiate(sacredGroveAreana, new Vector3(0f, 0f, 224f), new Quaternion()));
      this.Map.Add(3, Object.Instantiate(sacredGroveAreana, new Vector3(112f, 0f, 0f), new Quaternion()));
      this.Map.Add(4, Object.Instantiate(sacredGroveAreana, new Vector3(112f, 0f, 112f), new Quaternion()));
      this.Map.Add(5, Object.Instantiate(sacredGroveAreana, new Vector3(112f, 0f, 224f), new Quaternion()));
      this.Map.Add(6, Object.Instantiate(sacredGroveAreana, new Vector3(224f, 0f, 0f), new Quaternion()));
      this.Map.Add(7, Object.Instantiate(sacredGroveAreana, new Vector3(224f, 0f, 112f), new Quaternion()));
      this.Map.Add(8, Object.Instantiate(sacredGroveAreana, new Vector3(224f, 0f, 224f), new Quaternion()));
    }
  }
}