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
                if (GameManager.Instance.GetKitchen())
                {
                    TriggerAnimation("Kitchen");
                }
                else
                {
                    LockedText();
                }
                    break;

            case "BathroomKey":
                if (GameManager.Instance.GetBathroom())
                {
                    TriggerAnimation("Bathroom");
                }
                else
                {
                    LockedText();
                }
                break;

            case "BedRoomKey":
                if (GameManager.Instance.GetBedroom())
                {
                    TriggerAnimation("Bedroom");
                }
                else
                {
                    LockedText();
                }
                break;

            case "BasementKey":
                if (GameManager.Instance.GetBasement())
                {
                    TriggerAnimation("Basement");
                }
                else
                {
                    LockedText();
                }
                
                break;
            default: break;
        }

        

    }

    private void TriggerAnimation(string tag)
    {
        doorAnimator.SetTrigger(tag);
    }

    private void LockedText()
    {
        GameManager.Instance.InfoText("Kilitli.");
    }
}
