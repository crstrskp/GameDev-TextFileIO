using System;
using System.IO;
using System.Linq;
using UnityEngine;

public class ScoreSerializer : MonoBehaviour
{
    [SerializeField] private Score m_score;

    private string m_path;

    private void OnEnable()
    {
        SetPath();
        m_score.SetScore(ReadScoreFromFile());
    }

    private void OnDestroy()
    {
        WriteScoreToFile(m_score.GetScore());
    }

    private void SetPath() => m_path = Application.dataPath + "score.txt";


    

    public void WriteScoreToFile(int score)
    {
        using (StreamWriter sw = File.AppendText(m_path))
        {
            sw.WriteLine(m_score.GetScore().ToString());
        }
            
    }

    public int ReadScoreFromFile()
    {
        int i = 0;

        var s = File.ReadAllLines(m_path).Last();

        i = int.Parse(s);

        return i;
    }


}
