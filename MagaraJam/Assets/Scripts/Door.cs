using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour,IInteractable
{
    private Animator doorAnimator;

    // Start is called before the first frame update
    private void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }
    public void Interact()
    {

        switch (this.gameObject.tag)
        {
            case "KitchenKey":
                TriggerAnimation("Kitchen");
                break;
            case "BathroomKey":
                TriggerAnimation("Bathroom");
                break;
            case "BedRoomKey":
                TriggerAnimation("Bedroom");
                break;
            case "BasementKey":
                TriggerAnimation("Basement");
                break;
            default: break;
        }

        

    }

    private void TriggerAnimation(string tag)
    {
        doorAnimator.SetTrigger(tag);
    }
}
