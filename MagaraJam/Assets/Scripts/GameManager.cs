using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private bool knife, drawerKnob, flashlight, powerCellComplete, salonCode,book,lamp;
    private int powerCell, snakeEye;

    private bool basement, kitchen, bathroom, bedroom;
    [SerializeField] private TMP_Text infoText;

    private static GameManager instance;

    public static GameManager Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
           
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        knife = false;
        drawerKnob = false;
        flashlight = false;
        powerCellComplete = false;
        salonCode = false;
        basement = false;
        bedroom = false;
        book = false;
        kitchen = false;
        bathroom = false;
        lamp=false;
        
        powerCell = 0;
        snakeEye = 0;

    }

    public void InfoText(string text)
    {
        infoText.text = text;
        infoText.gameObject.SetActive(true);
        StartCoroutine(DisableInfo());
    }

    private IEnumerator DisableInfo()
    {
        yield return new WaitForSeconds(3f);
        infoText.gameObject.SetActive(false);

    }
    public void Knife()
    {
        knife=true;
    }
    public void Basement()
    {
        basement = true;

        InfoText("Sonunda bodrumun anahtarýný buldum!");
        
    }
    public void Bedroom()
    {
        bedroom = true;

        InfoText("Yatak Odasý anahtarýnýn buradan çýkmasýný beklemezdim!");

    }
    public void Kitchen()
    {
        kitchen = true;
        InfoText("Mutfak anahtarýný buldum!");
    }
    public void Bathroom()
    {
        bathroom = true;
        InfoText("Ýþte banyo anahtarý artýk banyo kapýsýný açabilirim!");
    }
    public void Lamp()
    {
        lamp = true;
        InfoText("Ýþe yarayabilir.");
    }
    public void Flashlight()
    {
        flashlight=true;
        InfoText("Feneri açmak için F tuþuna bas!");

        

    }
    public void DrawerKnob()
    {
        drawerKnob=true;

        InfoText("Bu çekmece kolunun nereye ait olduðunu bulmalýyým!");

    }
    public void SnakeEyes()
    {
        if (snakeEye < 2)
        {

        snakeEye++;
        }
        InfoText("Bu göz bir yere ait olmalý!");
    }
    public void OneSnakeEyePlaced()
    {
        if(snakeEye > 0)
        {
          snakeEye--;

        }
        InfoText("Diðer gözü de bulmam gerekiyor!");

    }
    public void PowerCells()
    {
        if(powerCell <= 5)
        {
            powerCell++;
           

        }
        else
        {
            powerCellComplete=true;
            InfoText("Sanýrým ihtiyacým olan bütün güç hücrelerini topladým!");

        }
    }

    public void SalonCode()
    {
        salonCode = true;
        InfoText("Bu kod salonun kapýsýný açan kod olmalý!");
    }
    public void ChosenBook()
    {
        book = true;
        InfoText("Bu kitaba bayýlýrým. Alsam kimse fark etmez herhalde!");
    }
    public bool GetKnife()
    {
        return knife;
    }
    public bool GetBook()
    {
        return book;
    }
    public bool GetDrawerKnob()
    {
        return drawerKnob;
    }
    public bool GetFlashlight()
    {
        return flashlight;
    }
    public bool PowerCellComplete()
    {
        return powerCellComplete;
    }
    public int SnakeEyeCount()
    {
        return snakeEye;
    }
    public bool GetSalonCode()
    {
        return salonCode;
    }
    public bool GetBasement()
    {
        return basement;
    }
    public bool GetKitchen()
    {
        return kitchen;
    }
    public bool GetBedroom()
    {
        return bedroom;
    }
    public bool GetBathroom()
    {
        return bathroom;
    }
    public bool GetLamp()
    {
        return lamp;
    }
}
