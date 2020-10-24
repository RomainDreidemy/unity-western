using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyHit : MonoBehaviour
{

    public GameObject BodyHitRed;
    public GameObject BodyNoHitRed;

    void Start() {
        this.PlayerBodyNoHitRed();   
    }

    public void PlayerBodyNoHitRed()
    {
        this.BodyHitRed.SetActive(false);
        this.BodyNoHitRed.SetActive(true);

    }

    public void PlayerBodyHitRed()
    {
        this.BodyHitRed.SetActive(true);
        this.BodyNoHitRed.SetActive(false);


    }
}
