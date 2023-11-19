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

        InfoText("Sonunda bodrumun anahtar�n� buldum!");
        
    }
    public void Bedroom()
    {
        bedroom = true;

        InfoText("Yatak Odas� anahtar�n�n buradan ��kmas�n� beklemezdim!");

    }
    public void Kitchen()
    {
        kitchen = true;
        InfoText("Mutfak anahtar�n� buldum!");
    }
    public void Bathroom()
    {
        bathroom = true;
        InfoText("��te banyo anahtar� art�k banyo kap�s�n� a�abilirim!");
    }
    public void Lamp()
    {
        lamp = true;
        InfoText("��e yarayabilir.");
    }
    public void Flashlight()
    {
        flashlight=true;
        InfoText("Feneri a�mak i�in F tu�una bas!");

        

    }
    public void DrawerKnob()
    {
        drawerKnob=true;

        InfoText("Bu �ekmece kolunun nereye ait oldu�unu bulmal�y�m!");

    }
    public void SnakeEyes()
    {
        if (snakeEye < 2)
        {

        snakeEye++;
        }
        InfoText("Bu g�z bir yere ait olmal�!");
    }
    public void OneSnakeEyePlaced()
    {
        if(snakeEye > 0)
        {
          snakeEye--;

        }
        InfoText("Di�er g�z� de bulmam gerekiyor!");

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
            InfoText("San�r�m ihtiyac�m olan b�t�n g�� h�crelerini toplad�m!");

        }
    }

    public void SalonCode()
    {
        salonCode = true;
        InfoText("Bu kod salonun kap�s�n� a�an kod olmal�!");
    }
    public void ChosenBook()
    {
        book = true;
        InfoText("Bu kitaba bay�l�r�m. Alsam kimse fark etmez herhalde!");
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
