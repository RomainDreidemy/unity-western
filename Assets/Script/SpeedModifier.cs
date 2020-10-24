using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedModifier : MonoBehaviour
{

    Global globalRef;

    public float Duree = 3; // Durée en seconde
    float SpeedInit;
    public float Acceleration = 10;

    public AudioSource AudioSnake;

    bool IsAccell = false;

    float AccelEnCours;

    // Start is called before the first frame update
    void Start()
    {
        this.globalRef = GetComponent<Global>();
    }

    public void DoubleSpeed(GameObject obj) 
    {
        MalusVitesseFactor factorComp = obj.GetComponent<MalusVitesseFactor>();
        this.AudioSnake.Play();
        
        if(!this.IsAccell){
            this.IsAccell = true;

            if(factorComp != null){
                globalRef.Speed += factorComp.SpeedFactor;
                this.AccelEnCours = factorComp.SpeedFactor;
            }else{
                globalRef.Speed += this.Acceleration;
                this.AccelEnCours = this.Acceleration;
            }

            Invoke("ResetSpeed", this.Duree);
        }
        
    }

    void ResetSpeed()
    {
        this.globalRef.Speed -= this.Acceleration;
        this.IsAccell = false;
    }
}
