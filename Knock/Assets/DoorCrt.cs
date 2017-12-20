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
    public int Keyflg;
    public bool Knock;

    // Use this for initialization
    void Start () {
        Knock = false;
        this.Animator = GetComponent<Animator>();
        Open = false;
        Close = true;
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
            Open = !Open;
            Close = !Close;

        }

        this.Animator.SetBool("Open", Open);
        this.Animator.SetBool("Close", Close);
    }
}
