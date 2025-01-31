﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerchArea : MonoBehaviour {
    public ZombieNaviController m_enemy;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("In Player");
            m_enemy.Serchmode = 2;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Exit Player");
            m_enemy.Serchmode = 0;
            m_enemy.Speed = 0f;
            m_enemy.m_timer = 0f;
        }
    }
}