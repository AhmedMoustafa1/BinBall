using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public IntField score;
    public IntField highScore;
    // Start is called before the first frame update
    public void Start()
    {
        ResetScore();
    }

    public void IncreaseScore()
    {
        score.Value += 1;
        if (score.Value>highScore.Value)
        {
            highScore.Value = score.Value;
        }
    }

    public void ResetScore()
    {
        score.Value = 0;
    }
}
