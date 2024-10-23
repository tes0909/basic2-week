using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    public TextMeshProUGUI scoreText;
    void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreButton.OnScoreChanged += RefreshUI;
    }

    

    void Start()
    {
        
    }

    void RefreshUI(int newScore)
    {
        scoreText.text = $"Current Score : {newScore}";
    }
}
