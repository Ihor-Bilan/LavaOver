using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    void Interact();
}

public class ObjectInteraction : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("The object was interacted with!");
    }
}

public class InterfaceExample : MonoBehaviour
{
    void Start()
    {
        ObjectInteraction objInteraction = new ObjectInteraction();
        IInteractable interactable = objInteraction;
        interactable.Interact();
    }
}
