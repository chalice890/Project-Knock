using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCrt : MonoBehaviour {
    private Animator Animator;

    public bool Open;
    public bool Close;
    public bool Click;
    private int NowKey;
    private int OldKey;
    private int Keyflg;

    // Use this for initialization
    void Start () {
        this.Animator = GetComponent<Animator>();
        Open = false;
        Close = false;
        Click = false;
    }

    // Update is called once per frame
    void Update () {

        OldKey = NowKey;
        if (Input.GetMouseButton(0)) NowKey = 1;
        else NowKey = 0;
        Keyflg = NowKey & ~OldKey;

        if (Click && Keyflg == 1)
        {
                if (Open != true)
                {
                    Open = true;
                    Close = false;
                }
                else
                {
                    Close = true;
                    Open = false;
                }
        }

        this.Animator.SetBool("Open", Open);
        this.Animator.SetBool("Close", Close);
    }
}
