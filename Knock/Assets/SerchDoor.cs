using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerchDoor : MonoBehaviour {
    public DoorCrt DoorCrt;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy" && DoorCrt.Click == false)
        {
            DoorCrt.Open = true;
            DoorCrt.Close = false;
        }
    }
}