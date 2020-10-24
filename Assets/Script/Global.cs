using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Global : MonoBehaviour
{

    public float Speed = 10;
    public float MultSpeed = 0.1f;

    public static int LastScore;

    public static LevelDificulty DIFICULTY;

    public enum LevelDificulty : int { Easy = 0, Medium = 1, Hardcore = 2}

    public void SetDificulty(int dif = (int)LevelDificulty.Easy)
    {
        Debug.Log(dif);
        Global.DIFICULTY = (LevelDificulty)dif;
        SceneManager.LoadScene("Game");
    }

    public void SpeedByTimePassed()
    {
        this.Speed += this.MultSpeed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        this.SpeedByTimePassed();
    }
}
