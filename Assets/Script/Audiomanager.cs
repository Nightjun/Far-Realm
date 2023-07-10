using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Audiomanager : MonoBehaviour
{
    public static Audiomanager instance;

    public Slider vslider;
    public sound[] sounds;

    public static float thevule=1;

    private void Awake()
    {
        vslider.value = thevule;
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);


        foreach(sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Update()
    {
        vslider = UIcall.instance.vsliderr;
        foreach (sound s in sounds)
        {
            s.source.volume = s.volume*vslider.value;
        }
        thevule = vslider.value;
    }

    public void Play(string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("not found sound");
            return;
        }
        s.source.Play();
    }
    public void StopPlay(string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("not found sound");
            return;
        }
        s.source.Stop();
    }
}
