using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_Level : MonoBehaviour
{
    public string sceneNameToLoad;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ��Ǩ�ͺ����������繼�������ҹ�鹷�������Դ�������¹�չ
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
