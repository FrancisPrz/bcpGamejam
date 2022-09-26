using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Se creó un script de clase Sound (sin Monobehaviour) para utilizarlo como array.
    public Sound[] sounds;
    //Se creó una variable para haya una música de fondo y se pueda cambiar dependiendo de la escena. 
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

        //Se utilizó un loop para modificar cada uno de los elementos agregados al Array.


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
        //Uso del método creado con la música de fondo elegida.
        Play(sceneTheme);
    }


    //Método para reproducir la pista seleccionada.
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("No se encontró: " + name);
            return;
        }

        s.source.Play();
    }
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("No se encontró: " + name);
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
            Debug.LogWarning("No se encontró: " + name);
            return;
        }

        s.source.Play();
    }

}
