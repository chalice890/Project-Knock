using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Main");
        }
        if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene("Start");
        }
    }
}
