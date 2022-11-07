using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npc : MonoBehaviour
{
    Transform player;
    NavMeshAgent nav;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        nav.SetDestination(player.position);
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "bala")
        {
            Destroy(gameObject);
        }
    }
}
