using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro; // Adicione este namespace para usar TextMeshPro

public class Score : MonoBehaviour
{
    public static event UnityAction<float> ScoreUp;
    public TextMeshProUGUI scoreText; // Variável para o componente TextMeshPro

    private int score;

    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText(); // Atualizar o texto cada vez que a pontuação muda
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}