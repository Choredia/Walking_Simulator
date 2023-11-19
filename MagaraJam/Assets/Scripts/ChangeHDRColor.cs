using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHDRColor : MonoBehaviour
{
    public Material targetMaterial;
    public Color newColor = Color.red; // Yeni renk
    public float targetIntensity = 2f; // Hedef intensity de�eri
    public float transitionDuration = 1f; // Ge�i� s�resi (saniye)

    private float elapsedTime = 0f; // Ge�en s�re

    void Update()
    {
        if (targetMaterial == null)
        {
            return;
        }

        elapsedTime += Time.deltaTime;

        float t = elapsedTime / transitionDuration;

        // Renk ge�i�ini yap
        Color lerpedColor = Color.Lerp(Color.black, newColor, t);
        targetMaterial.SetColor("_EmissionColor", lerpedColor);

        // Intensity ge�i�ini yap
        float lerpedIntensity = Mathf.Lerp(0f, targetIntensity, t);
        targetMaterial.SetFloat("_EmissionScaleUI", lerpedIntensity);

        targetMaterial.EnableKeyword("_EMISSION");
        targetMaterial.globalIlluminationFlags = MaterialGlobalIlluminationFlags.RealtimeEmissive;

        if (elapsedTime >= transitionDuration + 0.2f)
        {
            // Globe a��l�r
            Destroy(this);
        }
        
    }
}