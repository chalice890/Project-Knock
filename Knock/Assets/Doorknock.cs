using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorknock : MonoBehaviour
{
    public DoorCrt DoorCrt;
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (DoorCrt.Close == true && DoorCrt.Click == true && DoorCrt.Keyflg == 1)
        {
            audioSource.clip = audioClip2;
            audioSource.Play();
        }
        if (DoorCrt.Knock == true)
        {
            audioSource.clip = audioClip1;
            audioSource.Play();
            DoorCrt.Knock = false;
        }
    }
}
