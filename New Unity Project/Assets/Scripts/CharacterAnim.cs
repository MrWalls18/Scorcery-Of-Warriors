using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    [SerializeField]private Animator leftPunch, rightPunch;

     

    private void Start() {
        
    }

    private void Update() {
        
        if(Input.GetMouseButtonUp(0))
        {
            leftPunch.SetBool("isPunching", true);
        }
        else
            leftPunch.SetBool("isPunching", false);


        if (Input.GetMouseButtonUp(1))
        {
            rightPunch.SetBool("isPunching", true);
        }
        else
            rightPunch.SetBool("isPunching", false);

    }
}
