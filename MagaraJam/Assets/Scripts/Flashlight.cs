using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private bool isActive = false;
    [SerializeField] private GameObject flashlight;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && GameManager.Instance.GetFlashlight())
        {
            isActive = !isActive;
            FlashlightToggle(isActive);
        }
    }

    private void FlashlightToggle(bool isActive)
    {
        flashlight.SetActive(isActive);
    }
}
