using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cama : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string InteactionPrompt => prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Dormir!");
        return true;
    }
}
