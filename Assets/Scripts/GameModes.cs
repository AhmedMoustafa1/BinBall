using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum modes
{
    Training,
    Timed_Game
}

public class GameModes : MonoBehaviour
{
    public Timer timer;
    public modes CurrentGameMode;
    public BallsGenerator generator;
    public BoolField moveBin;
    public IntField score;
    public FloatField binSpeed;
    public StringField gameMode;
    public GameEvent gameStarted;

    private AudioSource _as;
    public AudioClip trainig;
    public AudioClip gameStart;
    public AudioClip trainingEnd;
    public AudioClip gameEnded;
    public void StartTimedGame()
    {
        generator.canGenerate = true;
        generator.GenerateBall();

        timer.StartTimer(90, TimerType.Decrement);
        CurrentGameMode = modes.Timed_Game;
        score.Value = 0;
        gameMode.Value = CurrentGameMode.ToString();
        gameStarted.Raise();
        binSpeed.Value = .2f;
        moveBin.Value = true;
        _as.clip = gameStart;
        _as.Stop();
        _as.Play();

    }

    public void StartTraining()
    {
        generator.canGenerate = true;
        CurrentGameMode = modes.Training;
        generator.GenerateBall();
        score.Value = 0;
        gameMode.Value = CurrentGameMode.ToString();
        gameStarted.Raise();
        binSpeed.Value = .2f;
        moveBin.Value = true;
        _as.clip = trainig;
        _as.Stop();
        _as.Play();
    }



    public void CheckTrainingStatus()
    {
        if (CurrentGameMode == modes.Training && score.Value == 5)
        {
            CurrentGameMode = modes.Timed_Game;
            generator.canGenerate = false;
            Debug.Log("hamada");
            moveBin.Value = false;
            _as.clip = trainingEnd;
            _as.Stop();
            _as.Play();
            Invoke("StartTimedGame",5);
        }
      
    }

    public void EndGame()
    {
        Debug.Log("gameENdedooo");

        if (CurrentGameMode == modes.Timed_Game)
        {
            generator.canGenerate = false;
            moveBin.Value = false;
            _as.clip = gameEnded;
            _as.Stop();
            _as.Play();
        }
    }
    public void Start()
    {
        binSpeed.Value = .2f;
        moveBin.Value = false;
        _as = this.GetComponent<AudioSource>();
    }
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            StartTraining();
        }

    }
}
