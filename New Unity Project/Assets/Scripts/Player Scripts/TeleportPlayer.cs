using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public float teleportDistance = 1f;
    public float teleportCooldown = 1f;
    private float timeSinceTeleport = 0f;

    public Transform teleportCheck;

    private void Awake() 
    {
        timeSinceTeleport = teleportCooldown;
        //Puts teleportCheck in place
        teleportCheck.position += Vector3.forward * teleportDistance;     
    }

    
    void FixedUpdate()
    {
        //Gets input from playe
        if(Input.GetKey(KeyCode.C) 
            && timeSinceTeleport > teleportCooldown 
                && PlayerMovement.Instance.isGrounded)
        {
            //Ray is shot from player to confirm a safe area to teleport 
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, teleportDistance))
            {
                //Teleports player if
                //(A)No wall was hit
                //(B)Area is not occupied
                if (!hit.collider.CompareTag("Obstacle")
                    && !Physics.CheckSphere(teleportCheck.position, 0.1f))
                {
                    this.gameObject.transform.position = teleportCheck.position;
                    timeSinceTeleport = 0f;
                }    
            }
            else
            {
                this.gameObject.transform.position = teleportCheck.position;
                transform.TransformDirection(Vector3.forward);

                timeSinceTeleport = 0f;
            }
        }
        timeSinceTeleport += Time.deltaTime;
    }
}
