using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffAttack : MonoBehaviour
{
    public GameObject staffProjectile;
    [SerializeField] private Transform spawnPoint;


    public void Attack()
    {
        GameObject staffProjectileClone;

        staffProjectileClone = Instantiate(staffProjectile, spawnPoint.position, spawnPoint.rotation);

    }
}
