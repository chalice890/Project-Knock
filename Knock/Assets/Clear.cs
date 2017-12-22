using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour {
    [SerializeField]
    private bool ClearFlg;
    public GameObject Sekiban1;
    public GameObject Sekiban2;
    public GameObject Sekiban3;
    private Animator animator;

    void Start()
    {
        this.animator = GetComponent<Animator>();
        ClearFlg = false;
    }

    void Update()
    {
        if (Sekiban1 == null && Sekiban2 == null && Sekiban3 == null)
        {
            Debug.Log("Crear");
            ClearFlg = true;
            this.animator.SetBool("Open", true);
            this.animator.SetBool("Close", false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (ClearFlg == true)
            {
                Debug.Log("Your Alive");
                SceneManager.LoadScene("Clear");
            }
        }
    }
}