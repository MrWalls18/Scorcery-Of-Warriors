using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBGAudio : MonoBehaviour
{
    public void DestroyMainMenuAudio()
    {
        Destroy(GameObject.Find("BGAudio"));
    }
}
