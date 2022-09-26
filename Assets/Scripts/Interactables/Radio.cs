using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour,IInteractable

{
    [SerializeField] private string prompt;
    public string InteactionPrompt => prompt;

    public AudioManager audioMan;

    public bool encendida;

    private string nameMusic;
    private void Start()
    {
        audioMan = FindObjectOfType<AudioManager>();
        encendida = false;
    }

    public bool Interact(Interactor interactor)
    {
        if (!encendida)
        {
            int i = Random.Range(1, 5);
            nameMusic = "Musica_" + i.ToString();
            audioMan.Play(nameMusic);
        }
        else 
        {
            audioMan.Stop(nameMusic);
        }

        return true;
    }

}
