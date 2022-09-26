using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Puerta : MonoBehaviour, IInteractable
{
    [SerializeField] private UnityEvent _event;
    [SerializeField] private string prompt;

    public string nameScene;

    public string InteactionPrompt => prompt;

    public bool Interact(Interactor interactor)
    {
        _event.Invoke();
        //SceneManager.LoadScene(nameScene);
        return true;
    }

}
