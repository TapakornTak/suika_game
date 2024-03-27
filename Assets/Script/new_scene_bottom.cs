using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class new_scene_bottom : MonoBehaviour
{
    public string targetSceneName;
    public Button move;

    public AudioClip clickSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        move.onClick.AddListener(ChangeScene);
    }

    public void ChangeScene()
    {
        audioSource.PlayOneShot(clickSound);
        SceneManager.LoadScene(targetSceneName);
    }
}
