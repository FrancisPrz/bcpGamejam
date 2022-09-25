using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laptop : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public GameObject panelPC;
    public string InteactionPrompt => prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Mostrar Laptop");
        panelPC.SetActive(true);
        return true;
    }
}
