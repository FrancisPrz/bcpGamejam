using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDeEscenas : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene("Primera Escena");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Segunda Escena");
    }
}
