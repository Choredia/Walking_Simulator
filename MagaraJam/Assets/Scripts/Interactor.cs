using System.Collections;
using System.Collections.Generic;
using UnityEngine;


interface IInteractable
{
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    public float interactRange;
    public LayerMask interactMask;
    [SerializeField] private GameObject interactUI;
    // Start is called before the first frame update
    void Start()
    {
        interactUI.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
         Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, interactRange, interactMask ))
        {
            if (hit.collider.gameObject.TryGetComponent(out IInteractable interactObj)  ) //DoorLayer
            {
                interactUI.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactUI.SetActive(false);
                    interactObj.Interact();
                }
            }
            else
            {
                interactUI.SetActive(false);
            }
        }
        else
        {
            interactUI.SetActive(false);
        }

    }
}
