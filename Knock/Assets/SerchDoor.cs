using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerchDoor : MonoBehaviour {
    public DoorCrt DoorCrt;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            DoorCrt.Click = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            DoorCrt.Click = false;
        }
    }
}