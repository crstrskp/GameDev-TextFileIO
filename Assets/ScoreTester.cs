using UnityEngine;

public class ScoreTester : MonoBehaviour
{
    [SerializeField] private Score m_score;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            m_score.IncreaseScore();
        }
        
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            m_score.DecreaseScore();
        }
    }
}
