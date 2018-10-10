using UnityEngine;
using UnityEngine.Rendering;

namespace Assets
{
  public class SunManager {
    public GameObject SunObject;
    public Light SunLight { get; set; }

    public void SunSet() {
      this.SunObject = new GameObject("Sun");
      this.SunObject.transform.position = new Vector3(-54.5f, 191.3f, 95.1f);
      this.SunObject.transform.Rotate(120f, -30f, 0f);
      this.SunObject.transform.localScale = new Vector3(1f, 1f, 1f);
      this.SunLight = this.SunObject.AddComponent<Light>();
      SetSunLight(SunLight);
    }

    private void SetSunLight(Light sunLight) {
      sunLight.type = LightType.Directional;
      sunLight.color = Color.white;
      sunLight.lightmapBakeType = LightmapBakeType.Realtime;
      sunLight.intensity = 1;
      sunLight.bounceIntensity = 1;
      sunLight.shadows = LightShadows.Soft;
      sunLight.shadowStrength = 1f;
      sunLight.shadowResolution = LightShadowResolution.FromQualitySettings;
      sunLight.shadowBias = 0.05f;
      sunLight.shadowNormalBias = 0.4f;
      sunLight.shadowNearPlane = 0.2f;
      sunLight.cookieSize = 10f;
      sunLight.renderMode = LightRenderMode.Auto;
    }
  }
}