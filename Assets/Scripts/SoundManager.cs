using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource AuSource;
    public AudioClip StartIntroBGM;
    public AudioClip NormalBGM;

    void Start()
    {
        AuSource.Play();
    }

    void Update()
    {
        if (!AuSource.isPlaying)
        {
            AuSource.clip = NormalBGM;
            AuSource.Play();
        }
    }
}
