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
                    GameManager.Instance.InfoText("Bir býçak eksik duruyor. Býçaðý bulup yerleþtirmeliyim!");
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
                    GameManager.Instance.InfoText("Bu çekmeceyi açmak için çekmece koluna ihtiyacým var!"); 
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
                    GameManager.Instance.InfoText("Yeteri kadar güç hücresi toplayamadým!");
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
                    GameManager.Instance.InfoText("Þifreyi bilmiyorum!");
                }
                break;

            case "Tablo":

                this.gameObject.GetComponent<Animator>().enabled = true;
                placedObject.SetActive(true);
                GameManager.Instance.InfoText("Tablonun arkasýndan bir þey düþtü!");
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
                    GameManager.Instance.InfoText("Kitaplýkta bir kitap eksik!");

                }
                    break;
            case "Jacket":

                GameManager.Instance.InfoText("Ceketin içinde bir þey var gibi duruyor!");
                placedObject.SetActive(true);
                break;

            case "Pillow":

                GameManager.Instance.InfoText("Yastýðýn altýnda bir þey var gibi duruyor!");
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
                    GameManager.Instance.InfoText("Ampul patlamýþ. Mutfakta bir ampul görmüþtüm sanki.");
                }
                    break;


            default:
                break;

        }


    }
}
