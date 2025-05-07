using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MiniGameScore : MonoBehaviour
{
    public TextMeshProUGUI BestScoreText;
    public TextMeshProUGUI bestScore;

    // Update is called once per frame
    public void Start()
    {
        BestScoreText.text = bestScore.ToString();
    }
}
