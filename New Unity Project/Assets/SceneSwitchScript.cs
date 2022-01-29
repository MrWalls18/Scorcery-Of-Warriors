using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchScript : MonoBehaviour
{
   public void Switch()
    {
        SceneManager.LoadScene("Game");
    }
}
