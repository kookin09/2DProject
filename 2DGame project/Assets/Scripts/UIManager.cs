using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI nowScore;
    public TextMeshProUGUI bestScore;

    public void Start()
    {
        if (scoreText == null)
        {
            Debug.LogError("scoreText is null");
            return;
        }
        if (nowScore == null)
        {
            Debug.LogError("nowScore is null");
            return;
        }
        if (bestScore == null)
        {
            Debug.LogError("bestScore is null");
            return;
        }

        nowScore.gameObject.SetActive(false);
        bestScore.gameObject.SetActive(false);
    }

    public void SetRestart()
    {
        nowScore.gameObject.SetActive(true);
        bestScore.gameObject.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
}
