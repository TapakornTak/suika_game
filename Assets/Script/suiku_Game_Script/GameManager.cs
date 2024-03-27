using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamenager : MonoBehaviour
{
    public static Gamenager Instance;

    [SerializeField] private Image _GameOverPanal;
    [SerializeField] private float _fadeTime;

    public float TimeTillGameOver = 1.5f;

    private void Awake()
    {
        if(Instance == null)
        {
             Instance = this;
        }

    }

    public void GameOver()
    {
        StartCoroutine(ResetGame());
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += FadeGame;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= FadeGame;
    }

    private IEnumerator ResetGame() 
    {
        _GameOverPanal.gameObject.SetActive(true);

        Color startColor = _GameOverPanal.color;
        startColor.a = 0f;
        _GameOverPanal.color = startColor;

        float elapsedTime = 0f;
        while (elapsedTime < _fadeTime)
        {
            elapsedTime += Time.deltaTime;

            float newAlpha = Mathf.Lerp(0f, 1f, (elapsedTime / _fadeTime));
            startColor.a += newAlpha;
            _GameOverPanal.color = startColor;

            yield return null;
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void FadeGame(Scene scene , LoadSceneMode mode)
    {
        StartCoroutine(FadeGameIn());
    }

    private IEnumerator FadeGameIn()
    {
        _GameOverPanal.gameObject.SetActive(true);
        Color startColor = _GameOverPanal.color;
        startColor.a = 1f;
        _GameOverPanal.color = startColor;

        float elapsedTime = 0f;
        while (elapsedTime < _fadeTime)
        {
            elapsedTime += Time.deltaTime;

            float newAlpha = Mathf.Lerp(0f, 1f, (elapsedTime / _fadeTime));
            startColor.a += newAlpha;
            _GameOverPanal.color = startColor;

            yield return null;
        }
                                                                          
        _GameOverPanal.gameObject.SetActive(false);

    }
}
