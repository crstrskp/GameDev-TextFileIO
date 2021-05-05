using System;
using UnityEngine;

public class Score : MonoBehaviour
{
    public event Action OnScoreChanged;
    public int GetScore() => m_score;
    
    private int m_score;

    private void OnEnable()
    {
        OnScoreChanged.Invoke();
    }

    public void IncreaseScore()
    {
        m_score++;
        OnScoreChanged.Invoke();
    }


    public void DecreaseScore()
    {
        m_score--;
        OnScoreChanged.Invoke();
    }
    public void SetScore(int i)
    {
        m_score = i;
        OnScoreChanged.Invoke();
    }
}
