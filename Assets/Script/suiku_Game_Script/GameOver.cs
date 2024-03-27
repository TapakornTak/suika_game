using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string sceneNameToLoad;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("1")) 
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
        else if (other.CompareTag("2"))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
        else if (other.CompareTag("3"))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
        else if (other.CompareTag("4"))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
        else if (other.CompareTag("5"))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
        else if (other.CompareTag("6"))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
        else if (other.CompareTag("7"))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
        else if (other.CompareTag("8"))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
        else if (other.CompareTag("9"))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
        else if (other.CompareTag("10"))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
