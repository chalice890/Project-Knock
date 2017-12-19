using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoor : MonoBehaviour
{
    public DoorCrt DoorCrt;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Door")
        {
            Debug.Log("On Trigger");
            DoorCrt = other.GetComponent<DoorCrt>();
            DoorCrt.Click = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Door")
        {
            Debug.Log("Off Trigger");
            DoorCrt = other.GetComponent<DoorCrt>();
            DoorCrt.Click = false;
        }
    }
}