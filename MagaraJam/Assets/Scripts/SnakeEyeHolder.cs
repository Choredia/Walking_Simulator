using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SnakeEyeHolder : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject eye1;
    [SerializeField] private GameObject eye2;
    [SerializeField] private GameObject lights;
    [SerializeField] private TMP_Text infoText;
    // Start is called before the first frame update
    public void Interact()
    {
        
        switch (GameManager.Instance.SnakeEyeCount())
        {
            case 0:
                InfoText();
                break;
            case 1:
                if (eye1.activeInHierarchy)
                {
                    eye2.SetActive(true);
                    GameManager.Instance.OneSnakeEyePlaced();
                }
                else
                {
                    eye1.SetActive(true);
                    GameManager.Instance.OneSnakeEyePlaced();

                }
                break;
            case 2:
                eye1.SetActive(true);
                eye2.SetActive(true);
                break; 

        }
        
    }

    private void Update()
    {
        if (eye1.activeInHierarchy && eye2.activeInHierarchy)
        {
            lights.SetActive(true);
            Destroy(this);
        }
    }

    private void InfoText()
    {
        infoText.text = "Gerekli nesne toplanmadý!";
        infoText.gameObject.SetActive(true);
        StartCoroutine(DisableInfo());
    }

    private IEnumerator DisableInfo()
    {
        yield return new WaitForSeconds(3f);
        infoText.gameObject.SetActive(false);

    }

}
