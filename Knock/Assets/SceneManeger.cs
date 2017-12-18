using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManeger : MonoBehaviour {

    GameObject enemy;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision enemy)
    {

        if(enemy.gameObject.name == "ZombieRig")
        {
            SceneManager.LoadScene("Start");
            Debug.Log("Enter");

        }



    }
}
