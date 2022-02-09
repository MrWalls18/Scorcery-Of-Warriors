using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : SingletonPattern<EnemySpawner>
{
    [SerializeField] private GameObject enemy_Ogre, enemy_Wizard;
    private GameObject enemyClone;
    
    [SerializeField] private List<Transform> spawnPoints;
    
    private float timeSinceSpawn = 0;
    public float timeBetweenSpawns = 5;
    
    private int randomSpawn, randomEnemy;
    public int enemiesThisWave = 50;
    public int spawnCounter = 0;
    
    

    protected override void Awake() {

        base.Awake();
        timeSinceSpawn = 0;
    }

    private void FixedUpdate()
    {
        timeSinceSpawn += Time.deltaTime;

        if (timeSinceSpawn > timeBetweenSpawns && spawnCounter <= enemiesThisWave)
        {
            randomSpawn = Random.Range(0, spawnPoints.Count);
            randomEnemy = Random.Range(1, 4);

            if (randomEnemy % 2 == 1)
            {
                enemyClone = Instantiate(enemy_Ogre, spawnPoints[randomSpawn].position, spawnPoints[randomSpawn].rotation);
            }
            else
            {
                enemyClone = Instantiate(enemy_Wizard, spawnPoints[randomSpawn].position, spawnPoints[randomSpawn].rotation);
            }

            timeSinceSpawn = 0;
            spawnCounter++;
        }
        
    }

}
