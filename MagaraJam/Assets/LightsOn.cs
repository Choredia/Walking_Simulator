using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOn : MonoBehaviour
{
    [SerializeField] private GameObject light1;
    [SerializeField] private GameObject light2;
    public LayerMask interactable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( light1.activeInHierarchy &&  light2.activeInHierarchy)
        {
            GetComponent<Animator>().enabled = true;
            
        }
    }

    private void SetLayer()
    {
        gameObject.layer = interactable;
    }
}
