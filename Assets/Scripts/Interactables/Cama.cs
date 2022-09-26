using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cama : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string InteactionPrompt => prompt;

    private AudioManager audioMan;
    private void Start()
    {
        audioMan = FindObjectOfType<AudioManager>();
    }

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Dormir!");
        SceneManager.LoadScene("Tienda");
        audioMan.Play("Cama");
        //Poner función de reinicio del día
        return true;
    }
}
