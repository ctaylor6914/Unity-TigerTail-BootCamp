using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    private int totalScore = 0;

    [SerializeField] private TextMeshProUGUI label;
    public void AddScore(int score)
    {
        totalScore += score;
        label.text = $"Score: {totalScore}";
    }
    
}
