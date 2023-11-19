using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        switch (this.gameObject.tag)
        {
            case "Knife":
                GameManager.Instance.Knife();
                break;

            case "DrawerKnob":

                GameManager.Instance.DrawerKnob();
                break;

            case "Flashlight":

                GameManager.Instance.Flashlight();
                break;

            case "PowerCell":

                GameManager.Instance.PowerCells();
                break;

            case "Book":

                GameManager.Instance.ChosenBook();
                break;
            case "SnakeEye":

                GameManager.Instance.SnakeEyes();
                break;
            case "BasementKey":

                GameManager.Instance.Basement();
                break;
            case "KitchenKey":

                GameManager.Instance.Kitchen();
                break;
            case "BedroomKey":

                GameManager.Instance.Bedroom();
                break;
            case "BathroomKey":

                GameManager.Instance.Bedroom();
                break;
            case "Lamp":
                GameManager.Instance.Lamp();
                break;
            case "Code":
                GameManager.Instance.SalonCode();
                break;
            default: 
                break;

        }
        Destroy(gameObject);
    }
}
