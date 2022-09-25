using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour,IInteractable

{
    [SerializeField] private string prompt;
    public string InteactionPrompt => prompt;
    public bool Interact(Interactor interactor)
    {
        Debug.Log("Se reproduce canción");
        //Poner un audio o algo
        return true;
    }

}
