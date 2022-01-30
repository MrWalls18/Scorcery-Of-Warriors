using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    private NavMeshAgent enemy;
    private Transform player;
    
    private void Awake()
    {
        //Sets enemy and player vars
        enemy = this.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Ogre").GetComponent<Transform>();    

    }

    void FixedUpdate()
    {
        enemy.SetDestination(player.position);
    }
}
