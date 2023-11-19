using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour, IInteractable
{
    public Animator drawerAnimator;

    // Start is called before the first frame update
    private void Start()
    {
    }
    public void Interact()
    {
        drawerAnimator.SetTrigger("Drawer");


    }
}
