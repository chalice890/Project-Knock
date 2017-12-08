using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAnimation : MonoBehaviour {
    public ZombieNaviController e_enemy;
    private Animator animator;

    private const string isWait = "isWait";
    private const string isWalk = "isWalk";
    private const string isRun = "isRun";

    // Use this for initialization
    void Start () {
        this.animator = GetComponent<Animator>();
        this.animator.SetBool(isRun, false);
        this.animator.SetBool(isWait, false);
        this.animator.SetBool(isWalk, true);
    }

    // Update is called once per frame
    void Update () {
        switch (e_enemy.Serchmode)
        {
            case 0:
                this.animator.SetBool(isRun, false);
                this.animator.SetBool(isWait, true);
                this.animator.SetBool(isWalk, false);
                break;
            case 1:
                this.animator.SetBool(isRun, false);
                this.animator.SetBool(isWait, false);
                this.animator.SetBool(isWalk, true);
                break;
            case 2:
                this.animator.SetBool(isRun, true);
                this.animator.SetBool(isWait, false);
                this.animator.SetBool(isWalk, false);
                break;
        }
	}
}
