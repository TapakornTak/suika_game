using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_next : MonoBehaviour
{
    public string sceneNameToLoad;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("10"))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }    
}
