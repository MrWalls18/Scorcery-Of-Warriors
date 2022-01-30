using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Hands"))
        {
            GameManager.Instance.score += 10;
        }

        else if (other.CompareTag("Ogre"))
        {
            GameManager.Instance.health -= 10;
        }

        Destroy(this.gameObject);
    }


}
