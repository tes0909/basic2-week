using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;
    public int score;
    public ScoreText scoreText;
    public event Action<int> OnScoreChanged; //외부호출

    private void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }


    private void PointUp()
    {
        score += 1;
        OnScoreChanged?.Invoke(score);
    }
}
