using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;
    UIManager uiManager;
    public TextMeshProUGUI NowScore;
    public TextMeshProUGUI bestScore;
    public GameObject endPanel;
    public UIManager UIManager
    {
        get { return uiManager; }
    }
    private void Awake()
    {
        gameManager = this;
        uiManager = FindObjectOfType<UIManager>();
    }
    private void Start()
    {
        uiManager.UpdateScore(0);
    }

    public void GameOver()
    {
        NowScore.text = nowScore.ToString();
        if (PlayerPrefs.HasKey("bestScore"))
        {
            int best = PlayerPrefs.GetInt("bestScore");

            if (best < nowScore)
            {
                PlayerPrefs.SetInt("bestScore", nowScore);
                bestScore.text = nowScore.ToString("N0");
            }
            else
            {
                bestScore.text = best.ToString("N0");
            }
        }
        else
        {
            PlayerPrefs.SetInt("bestScore", nowScore);
            bestScore.text = nowScore.ToString("N0");
        }
        endPanel.SetActive(true);
        Debug.Log("Game Over");
        uiManager.SetRestart();
    }

    public static GameManager Instance
    {
        get { return gameManager; }
    }

    private int nowScore = 0;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        nowScore += score;
        uiManager.UpdateScore(nowScore);
        Debug.Log("Score: " + nowScore);
    }

}
