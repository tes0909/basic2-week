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
    public Action<int> OnScoreChanged;

    private void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }


    private void PointUp()
    {
        score += 1;
        OnScoreChanged?.Invoke(score);
        Debug.Log($"점수추가 : {score}");
    }
}
