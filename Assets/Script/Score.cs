using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public int totalScore = 0;

    public void AddScore(int Value)
    {
        this.totalScore += Value;
    }

    public void RemoveScore(int Value)
    {
        this.totalScore -= Value;
    }

    void updateScoreboard()
    {
        //TODO : Update le scoreboard
    }
}
