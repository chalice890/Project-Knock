using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorknock : MonoBehaviour
{
    public DoorCrt DoorCrt;
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    private AudioSource audioSource;
    private bool Knock;

    void Start()
    {
        Knock = false;
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(DoorCrt.Open == true && DoorCrt.Keyflg == 0 && Knock == false)
        {
            audioSource.clip = audioClip1;
            audioSource.Play();
            Knock = true;
        }
        if (DoorCrt.Close == true && DoorCrt.Keyflg == 1)
        {
            audioSource.clip = audioClip2;
            audioSource.Play();
            Knock = false;
        }
    }
}
