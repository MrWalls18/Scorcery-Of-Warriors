using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent enemy;
    private Transform player;

    [SerializeField] private List<GameObject> ingredients;
    
    private void Awake()
    {
        //Sets enemy and player vars
        enemy = this.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Wizard").GetComponent<Transform>();    

    }

    void FixedUpdate()
    {
        enemy.SetDestination(player.position);
    }

    //Detects collision with wizard or attacks
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("StaffAttack"))
        {
            GameManager.Instance.score += 10;

            if (Random.Range(0, 4) == 3)
                Instantiate(ingredients[Random.Range(0, ingredients.Count)], transform.position, transform.rotation);            
        }

        else if (other.CompareTag("Wizard"))
        {
            GameManager.Instance.health -= 10;
        }

        Destroy(this.gameObject);
    }
}
