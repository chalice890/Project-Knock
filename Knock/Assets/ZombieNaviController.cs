using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieNaviController : MonoBehaviour {
    public NavMeshAgent m_navMeshAgent;

    enum SerchMode {WAIT_MODE, SERCH_MODE, RUN_MODE};

    //public Transform targetTF;
    public GameObject Enemy;
    private float xr;
    private float zr;
    [SerializeField]
    public int Serchmode;
    public float m_timer;
    private float SearchIntrval;
    public float Speed;

    // Use this for initialization
    void Start () {
        m_navMeshAgent = GetComponent<NavMeshAgent>();
        m_timer = 0;
        SearchIntrval = 10f;
        Speed = 5f;
        Serchmode = (int)SerchMode.SERCH_MODE;
        xr = Random.Range(-44, 44);
        zr = Random.Range(-33, 33);
        m_navMeshAgent.SetDestination(new Vector3(xr, 0, zr));
    }

    // Update is called once per frame
    void Update()
    {
        m_navMeshAgent.speed = Speed;

        switch (Serchmode)
        {
            case (int)SerchMode.WAIT_MODE:

                m_timer += Time.deltaTime;

                if (m_timer > 3)
                {
                    xr = Random.Range(-44, 44);
                    zr = Random.Range(-33, 33);
                    m_navMeshAgent.SetDestination(new Vector3(xr, 0, zr));
                    m_timer = 0;
                    Speed = 5f;
                    Serchmode = (int)SerchMode.SERCH_MODE;
                }
                break;
            case (int)SerchMode.SERCH_MODE:

                m_timer += Time.deltaTime;

                if (m_timer > SearchIntrval)
                {
                    xr = Random.Range(-44, 44);
                    zr = Random.Range(-33, 33);
                    m_navMeshAgent.SetDestination(new Vector3(xr, 0, zr));
                    m_timer = 0;
                    Speed = 5f;
                }
                if ((Enemy.transform.position.x >= m_navMeshAgent.destination.x - 1 && Enemy.transform.position.x <= m_navMeshAgent.destination.x + 1) &&
                                                                        (Enemy.transform.position.z >= m_navMeshAgent.destination.z - 1 && Enemy.transform.position.z <= m_navMeshAgent.destination.z + 1))
                {
                    m_timer = 0;
                    Serchmode = (int)SerchMode.WAIT_MODE;
                    Speed = 0f;
                    Debug.Log("ok");
                }
                break;
            case (int)SerchMode.RUN_MODE:
                m_navMeshAgent.SetDestination(GameObject.Find("FPSController").transform.position);
                Speed = 20f;
                break;
        }
    }
}