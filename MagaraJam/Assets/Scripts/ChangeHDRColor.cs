using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHDRColor : MonoBehaviour
{
    public Material targetMaterial;
    public Color newColor = Color.red; // Yeni renk
    public float targetIntensity = 2f; // Hedef intensity deðeri
    public float transitionDuration = 1f; // Geçiþ süresi (saniye)

    private float elapsedTime = 0f; // Geçen süre

    void Update()
    {
        if (targetMaterial == null)
        {
            return;
        }

        elapsedTime += Time.deltaTime;

        float t = elapsedTime / transitionDuration;

        // Renk geçiþini yap
        Color lerpedColor = Color.Lerp(Color.black, newColor, t);
        targetMaterial.SetColor("_EmissionColor", lerpedColor);

        // Intensity geçiþini yap
        float lerpedIntensity = Mathf.Lerp(0f, targetIntensity, t);
        targetMaterial.SetFloat("_EmissionScaleUI", lerpedIntensity);

        targetMaterial.EnableKeyword("_EMISSION");
        targetMaterial.globalIlluminationFlags = MaterialGlobalIlluminationFlags.RealtimeEmissive;

        if (elapsedTime >= transitionDuration + 0.2f)
        {
            // Globe açýlýr
            Destroy(this);
        }
        
    }
}