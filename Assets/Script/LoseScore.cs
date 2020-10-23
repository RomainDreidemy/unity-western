using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoseScore : MonoBehaviour
{
    public TextMeshProUGUI TxtScore;
    private Global GlobalRef;

    // Start is called before the first frame update
    void Start()
    {
        this.TxtScore.text = Global.LastScore.ToString();
    }
}
