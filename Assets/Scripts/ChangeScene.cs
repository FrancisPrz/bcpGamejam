using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int numberScene;
    
    public void SceneChange()
    {
        SceneManager.LoadScene(numberScene);
    }
}
