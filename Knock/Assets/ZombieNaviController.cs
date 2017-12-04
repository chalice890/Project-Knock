using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieNaviController : MonoBehaviour {
    public NavMeshAgent m_navMeshAgent;

    //public Transform targetTF;
    private float xr;
    private float zr;
    [SerializeField]
    public bool isSeach = true;
    private float m_timer;
    private float SearchIntrval = 8f;
    private float Speed = 5f;
    public Vector3 Serch;

    // Use this for initialization
    void Start () {
        m_navMeshAgent = GetComponent<NavMeshAgent>();
        m_navMeshAgent.SetDestination(new Vector3(30, 0, 30));
        m_timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_navMeshAgent.speed = Speed;

        if (isSeach)
        {
            m_timer += Time.deltaTime;

            if (m_timer >= SearchIntrval)
            {
                xr = Random.Range(-44, 44);
                zr = Random.Range(-33, 33);
                m_navMeshAgent.SetDestination(new Vector3(xr, 0, zr));
                m_timer = 0;
                Speed = 5f;
            }
        }
        else
        {
            Speed = 10f;
        }
    }
}