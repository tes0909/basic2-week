using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    public TextMeshProUGUI scoreText;
    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }
    void Start()
    {
        
    }

    public void RefreshUI()
    {
        scoreText.text = $"Current Score : {scoreButton.score}";
    }
}
