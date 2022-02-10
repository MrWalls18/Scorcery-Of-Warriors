using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    [SerializeField]private Animator leftHand;

    public float delayBetweenAnim = 1f;
    float timePassed = 0f;

    private void Start() 
    {
        timePassed = delayBetweenAnim;
    }

    private void FixedUpdate() 
    {
        timePassed += Time.deltaTime;

       if(timePassed > delayBetweenAnim)
       {
            //Gets input for LMB        
            if(Input.GetMouseButton(0))
            {
                leftHand.SetTrigger("isPunching");
                timePassed = 0f;
            }    

        } 

    }
}
