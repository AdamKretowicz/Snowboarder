using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] float onCrashDelay = 0.5f;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            Invoke("ReloadScene", onCrashDelay);
        }
    }    

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
    
}
