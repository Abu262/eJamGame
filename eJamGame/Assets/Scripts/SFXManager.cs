using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SFXManager : MonoBehaviour
{
    public Sound[] soundEffects;

    public static SFXManager instance;

    //Called on initial loading of the game
    void Awake()
    {
        //Start singleton creation
        if(instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        //End singleton creation

        //Init sfx
        foreach(Sound s in soundEffects)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clips[0];
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.playOnAwake = false;
        }
    }

    public Sound GetSFX(string name)
    {
        Sound s = Array.Find(soundEffects, sound => sound.name == name);
        if (s == null)
        {
            if (soundEffects.Length != 0)
                Debug.LogError(String.Format("Sound cannot be found with name: {0}.", name));
            else
                Debug.LogError("Sound Effects List is empty");
        }
        return s;
    }

    public void Play(string name)
    {
        Sound s = GetSFX(name);
        if (s == null)
            return;
        s.source.Play();
    }

    public void PlayWithPitchMod(string name)
    {
        Sound s = GetSFX(name);
        if (s == null)
            return;
        s.source.pitch = Random.Range(s.pitchMin, s.pitchMax);
        s.source.Play();
    }

    public void PlayWithVolumeMod(string name)
    {
        Sound s = GetSFX(name);
        if (s == null)
            return;
        s.source.volume = Random.Range(s.volumeMin, s.volumeMax);
        s.source.Play();
    }

    public void PlayWithBothMod(string name)
    {
        Sound s = GetSFX(name);
        if (s == null)
            return;
        s.source.pitch = Random.Range(s.pitchMin, s.pitchMax);
        s.source.volume = Random.Range(s.volumeMin, s.volumeMax);
        s.source.Play();
    }
    public void PlayRandomClip(string name)
    {
        Sound s = GetSFX(name);
        if (s == null)
            return;
        s.source.clip = s.clips[Random.Range(0, s.clips.Length)];
        s.source.Play();
    }
    public bool IsPlaying(string name)
    {
        Sound s = GetSFX(name);
        if (s == null)
            return false;
        return s.source.isPlaying;
    }
}
