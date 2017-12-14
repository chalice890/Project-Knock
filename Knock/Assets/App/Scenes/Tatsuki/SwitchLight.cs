using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLight : MonoBehaviour {

    GameObject spotlight; 


    // Use this for initialization
    void Start () {

      spotlight =  GameObject.Find("FPSController").transform.Find("FirstPersonCharacter").transform.Find("Spotlight").gameObject;

    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetMouseButtonDown(1))
        {
            spotlight.SetActive(!spotlight.activeSelf);
        }

	}
}
