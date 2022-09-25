using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puerta : MonoBehaviour,IInteractable
{
    [SerializeField] private string prompt;

    public string nameScene;

    public string InteactionPrompt => prompt;

    public bool Interact(Interactor interactor)
    {
        SceneManager.LoadScene(nameScene);
        return true;
    }

}
