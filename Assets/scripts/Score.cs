using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro; // Adicione este namespace para usar TextMeshPro

public class Score : MonoBehaviour
{
    public static event UnityAction OnScoreThresholdReached;
    public TextMeshProUGUI scoreText;
    private int score;

    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
        CheckScoreThreshold();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    void CheckScoreThreshold()
    {
        if (score % 120 == 0)
        {
            Debug.Log("Threshold reached, spawning boss.");
            OnScoreThresholdReached?.Invoke();
        }
    }
}
