using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicaController : MonoBehaviour
{
    public AudioSource mainMenu_AS;
    
    public void ApagarMusica()
    {
        if(mainMenu_AS.mute == false)
        {
            mainMenu_AS.mute = true;
        }
        else if(mainMenu_AS.mute == true)
        {
            mainMenu_AS.mute = false;
        }
    }
    //public void EncenderMusica()
    //{
    //    if (mainMenu_AS.mute == true)
    //    {
    //        mainMenu_AS.mute = false;
    //    }
    //}
}
