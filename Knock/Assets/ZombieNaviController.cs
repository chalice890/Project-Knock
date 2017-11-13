using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieNaviController : MonoBehaviour {
    private NavMeshAgent m_navMeshAgent;

    //public Transform targetTF;

    int r;
    [SerializeField]
    private bool isSeach = true;
    private float m_timer;
    [SerializeField]
    private float SearchIntrval = 60f;

	// Use this for initialization
	void Start () {
        m_navMeshAgent = GetComponent<NavMeshAgent>();
        m_navMeshAgent.SetDestination(new Vector3(0, 0, 0));

    }

    // Update is called once per frame
    void Update () {
        if (isSeach)
        {
            m_timer -= Time.deltaTime;

            if (m_timer <= 0)
            {
                r = Random.Range(-40, 40);

                m_navMeshAgent.SetDestination(new Vector3(r, 0, r));
                m_timer = SearchIntrval;
            }
        }
	}
}
