using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Se cre� un script de clase Sound (sin Monobehaviour) para utilizarlo como array.
    public Sound[] sounds;
    //Se cre� una variable para haya una m�sica de fondo y se pueda cambiar dependiendo de la escena. 
    public string sceneTheme;

    public static AudioManager instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        //Se utiliz� un loop para modificar cada uno de los elementos agregados al Array.


        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

    }

    void Start()
    {
        //Uso del m�todo creado con la m�sica de fondo elegida.
        Play(sceneTheme);
    }


    //M�todo para reproducir la pista seleccionada.
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("No se encontr�: " + name);
            return;
        }

        s.source.Play();
    }
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("No se encontr�: " + name);
            return;
        }

        s.source.Stop();
    }

    public void StopAndPlay(string name)
    {
        Sound t = Array.Find(sounds, sound => sound.name == sceneTheme);

        t.source.Stop();

        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("No se encontr�: " + name);
            return;
        }

        s.source.Play();
    }

}
