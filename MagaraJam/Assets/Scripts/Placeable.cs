using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Placeable : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject placedObject;
    public void Interact()
    {
        switch (this.gameObject.tag)
        {
            case "Knife":
                if (GameManager.Instance.GetKnife())
                {
                    placedObject.SetActive(true);
                    Destroy(this);
                }
                else
                {
                    GameManager.Instance.InfoText("Bir b��ak eksik duruyor. B��a�� bulup yerle�tirmeliyim!");
                }
                break;

            case "DrawerKnob":

                if (GameManager.Instance.GetDrawerKnob())
                {
                    placedObject.SetActive(true);
                    this.gameObject.GetComponent<Animator>().enabled = true;

                    Destroy(this);

                }
                else
                {
                    GameManager.Instance.InfoText("Bu �ekmeceyi a�mak i�in �ekmece koluna ihtiyac�m var!"); 
                }
                break;

            case "Machine":

                if (GameManager.Instance.PowerCellComplete())
                {
                    placedObject.SetActive(true);
                    Destroy(this);

                }
                else
                {
                    GameManager.Instance.InfoText("Yeteri kadar g�� h�cresi toplayamad�m!");
                }
                break;

            case "Salon":

                if (GameManager.Instance.GetSalonCode())
                {
                    placedObject.SetActive(true);
                    GetComponentInParent<Animator>().enabled= true;
                    Destroy(this);

                }
                else
                {
                    GameManager.Instance.InfoText("�ifreyi bilmiyorum!");
                }
                break;

            case "Tablo":

                this.gameObject.GetComponent<Animator>().enabled = true;
                placedObject.SetActive(true);
                GameManager.Instance.InfoText("Tablonun arkas�ndan bir �ey d��t�!");
                Destroy(this);

                break;

            case "Book":
                if (GameManager.Instance.GetBook())
                {
                    placedObject.SetActive(true);
                    this.gameObject.GetComponent<Animator>().enabled = true;
                    Destroy(this);
                }
                else
                {
                    GameManager.Instance.InfoText("Kitapl�kta bir kitap eksik!");

                }
                    break;
            case "Jacket":

                GameManager.Instance.InfoText("Ceketin i�inde bir �ey var gibi duruyor!");
                placedObject.SetActive(true);
                break;

            case "Pillow":

                GameManager.Instance.InfoText("Yast���n alt�nda bir �ey var gibi duruyor!");
                this.gameObject.GetComponent<Animator>().enabled = true;
                Destroy(this);

                break;

            case "Toilet":

                GameManager.Instance.InfoText("ewww!");
                this.gameObject.GetComponent<Animator>().enabled = true;
                Destroy(this);

                break;
            case "Lamp1":
                placedObject.SetActive(true) ;
                Destroy(this);
                break;
            case "Lamp2":
                if (GameManager.Instance.GetLamp())
                {
                    placedObject.SetActive(true);
                    Destroy(this);
                }
                else
                {
                    GameManager.Instance.InfoText("Ampul patlam��. Mutfakta bir ampul g�rm��t�m sanki.");
                }
                    break;


            default:
                break;

        }


    }
}
