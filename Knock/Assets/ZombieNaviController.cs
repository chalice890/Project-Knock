using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieNaviController : MonoBehaviour {
    private NavMeshAgent m_navMeshAgent;

    //public Transform targetTF;

    private float xr;
    private float zr;
    [SerializeField]
    private bool isSeach = true;
    private float m_timer;
    private float SearchIntrval = 10f;

    // Use this for initialization
    void Start () {
        m_navMeshAgent = GetComponent<NavMeshAgent>();
        m_navMeshAgent.SetDestination(new Vector3(30, 0, 30));
        m_timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSeach)
        {
            m_timer += Time.deltaTime;

            if (m_timer >= SearchIntrval)
            {
                xr = Random.Range(-30, 30);
                zr = Random.Range(-23, 23);
                m_navMeshAgent.SetDestination(new Vector3(xr, 0, zr));
                m_timer = 0;
            }
        }
    }
}