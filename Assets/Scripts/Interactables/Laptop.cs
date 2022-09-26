using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Laptop : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    [SerializeField] private UnityEvent _onInteract;
    public string InteactionPrompt => prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Mostrar Laptop");
        _onInteract.Invoke();
        return true;
    }
}
