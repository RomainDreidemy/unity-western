using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Global : MonoBehaviour
{
    public static int DIFICULTY;
    public static int EASY = 0;
    public static int MEDIUM = 1;
    public static int HARDCORE = 2;

    public void SetDificulty(int dif = 0)
    {
        Global.DIFICULTY = dif;
        SceneManager.LoadScene("Game");
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
