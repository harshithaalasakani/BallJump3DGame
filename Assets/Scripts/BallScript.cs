using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    
    void OnTriggerEnter(Collider target)
    {
        if(target.tag == "Enemy")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
}
