﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int totalScore = 0;

    public Text TxtScore;

    void Start()
    {
        this.updateScoreboard();
    }

    public void AddScore(int Value)
    {
        this.totalScore += Value;
        this.updateScoreboard();
    }

    public void RemoveScore(int Value)
    {
        this.totalScore -= Value;
        this.updateScoreboard();
    }

    void updateScoreboard()
    {
        //TODO : Update le scoreboard
        this.TxtScore.text = this.totalScore.ToString();
    }
}
