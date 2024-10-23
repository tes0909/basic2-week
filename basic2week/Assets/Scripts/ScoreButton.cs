using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;
    public int score;
    public ScoreText scoreText;

    private void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
        scoreButton.onClick.AddListener(scoreText.RefreshUI);
    }


    private void PointUp()
    {
        score += 1;
        Debug.Log($"점수추가 : {score}");
    }
}
