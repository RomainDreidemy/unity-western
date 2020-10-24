using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public int totalScore = 0;

    public TextMeshProUGUI TxtScore;
    public AudioSource AudioScore;

    void Start()
    {
        this.updateScoreboard();
    }

    public void AddScore(int Value)
    {
        this.totalScore += Value;
        this.updateScoreboard();
        Global.LastScore = this.totalScore;
        this.AudioScore.Play();
    }

    public void RemoveScore(int Value)
    {
        this.totalScore -= Value;
        this.updateScoreboard();
        Global.LastScore = this.totalScore;
    }

    void updateScoreboard()
    {
        this.TxtScore.text = this.totalScore.ToString();
    }
}
