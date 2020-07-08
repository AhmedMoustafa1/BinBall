using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreUI;
    public Text highScoreUI;
    public Text gameTypeUI;

    public IntField score;
    public IntField highScore;
    public StringField gameType;
    // Start is called before the first frame update

    public void UpdateUI()
    {
        scoreUI.text = "Score: "+(score.Value);
        highScoreUI.text = "HS: " + (highScore.Value);
        gameTypeUI.text =  (gameType.Value);

    }
}
