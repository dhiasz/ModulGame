using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;

    [Header("Audio clip")]
    public AudioClip backsound;


    private void Start()
    {
        musicSource.clip = backsound;
        musicSource.Play();
    }
}
