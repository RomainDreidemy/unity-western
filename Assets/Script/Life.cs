using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int PlayerLife = 5;
    int PlayerMaxLife = 5;
    public UnityEngine.UI.Image PictureLife1;
    public UnityEngine.UI.Image PictureLife2;
    public UnityEngine.UI.Image PictureLife3;
    public UnityEngine.UI.Image PictureLife4;
    public UnityEngine.UI.Image PictureLife5;

    Global globalRef;

    void Start()
    {
        this.globalRef = GetComponent<Global>();
        this.initLife();
        Debug.Log(this.PlayerMaxLife);
    }

    public void addPlayerLife(int Value)
    {
        if(this.PlayerLife < this.PlayerMaxLife)
        {
            this.PlayerLife += Value;
        }
    }

    public void removePlayerLife(int Value)
    {
        this.PlayerLife -= Value;

        if(this.PlayerLife <= 0)
        {
            //TODO : Changer de scene
            Debug.Log("Perdu");
        }
        else
        {
            switch (this.PlayerLife)
            {
                case 5 :
                    this.PictureLife5.enabled = true;
                break;
                case 4 :
                    this.PictureLife4.enabled = true;
                    this.PictureLife5.enabled = false;
                break;
                case 3 :
                    this.PictureLife3.enabled = true;
                    this.PictureLife4.enabled = false;
                break;
                case 2 :
                    this.PictureLife2.enabled = true;
                    this.PictureLife3.enabled = false;
                break;
                case 1 :
                    this.PictureLife2.enabled = false;
                break;
            }
        }
    }

    public void updateLifeboard()
    {
        //TODO : update l'affichage des vies
    }

    void initLife()
    {
        switch (Global.DIFICULTY)
        {
            case 0 :
                this.PlayerLife = this.PlayerMaxLife = 5;
                this.PictureLife1.enabled = true;
                this.PictureLife2.enabled = true;
                this.PictureLife3.enabled = true;
                this.PictureLife4.enabled = true;
                this.PictureLife5.enabled = true;
            break;
            case 1 : 
                this.PlayerLife = this.PlayerMaxLife = 3;
                this.PictureLife1.enabled = true;
                this.PictureLife2.enabled = true;
                this.PictureLife3.enabled = true;
                this.PictureLife4.enabled = false;
                this.PictureLife5.enabled = false;
            break;
            case 2 : 
                this.PlayerLife = this.PlayerMaxLife = 1;
                this.PictureLife1.enabled = true;
                this.PictureLife2.enabled = false;
                this.PictureLife3.enabled = false;
                this.PictureLife4.enabled = false;
                this.PictureLife5.enabled = false;
            break;
            
            default:
                this.PlayerLife = 5;
            break;
        }
    }
}
