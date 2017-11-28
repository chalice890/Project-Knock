using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieNaviController : MonoBehaviour {
    public NavMeshAgent m_navMeshAgent;

    //public Transform targetTF;
    public GameObject Player;
    private float xr;
    private float zr;
    [SerializeField]
    public bool isSeach = true;
    private float m_timer;
    private float SearchIntrval = 8f;
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