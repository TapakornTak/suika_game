using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_Level : MonoBehaviour
{
    public string sceneNameToLoad;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ตรวจสอบให้แน่ใจว่าเป็นผู้เล่นเท่านั้นที่ทำให้เกิดการเปลี่ยนซีน
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
