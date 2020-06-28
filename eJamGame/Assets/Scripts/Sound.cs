using UnityEngine.Audio;
using UnityEngine;

/// <summary>
/// Wrapper for all things needed for sound
/// </summary>
[System.Serializable]
public class Sound
{
    public string name;
    [Header("AudioSource Values")]
    [Tooltip("List of audio clips to use for a sound effect")]
    public AudioClip[] clips;
    [Tooltip("Default pitch")]
    [Range(0.0f, 5.0f)]
    public float pitch = 1.0f;
    [Tooltip("Default volume")]
    [Range(0.0f, 1.0f)]
    public float volume = 1.0f;
    public bool loop;

    //WARNING: Min < Max or Max > Min should never happen or else
    //pitch mod WILL throw an error
    [Header("Pitch Modulator Values")]
    [Tooltip("Minimum pitch at which the audio source will play in")]
    [Range(0.0f, 5.0f)]
    public float pitchMin = 0.0f;
    [Tooltip("Maximum pitch at which the audio source will play in")]
    [Range(0.0f, 5.0f)]
    public float pitchMax = 1.0f;

    //WARNING: Min < Max or Max > Min should never happen or else
    //volume mod WILL throw an error
    [Header("Volume Modulator Values")]
    [Tooltip("Minimum volume at which the audio source will play in")]
    [Range(0.0f, 1.0f)]
    public float volumeMin = 0.0f;
    [Tooltip("Maximum volume at which the audio source will play in")]
    [Range(0.0f, 1.0f)]
    public float volumeMax = 1.0f;

    [HideInInspector]
    public AudioSource source;
}
