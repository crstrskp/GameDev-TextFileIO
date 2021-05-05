using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text m_text;
    [SerializeField] private Score m_score;


    private void OnEnable() => m_score.OnScoreChanged += UpdateScore;

    private void OnDestroy() => m_score.OnScoreChanged -= UpdateScore;

    private void UpdateScore()
    {
        m_text.text = m_score.GetScore().ToString();
    }
}
