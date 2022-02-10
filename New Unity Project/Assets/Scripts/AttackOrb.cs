using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackOrb : MonoBehaviour
{
    [SerializeField] private float orbSpeed;


    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * orbSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        Destroy(this.gameObject);
    }

    
}
