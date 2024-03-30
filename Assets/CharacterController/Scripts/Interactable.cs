using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactable : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private bool isTriggered = false;
 
    public void Interact(InputAction.CallbackContext context)
    {
        if(context.started && isTriggered)
        {
            target.SetActive(!target.activeSelf);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isTriggered = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isTriggered = false;
        }
    }
}