using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int PlayerLife = 5;

    public void addPlayerLife(int Value)
    {
        this.PlayerLife += Value;
    }

    public void removePlayerLife(int Value)
    {
        this.PlayerLife -= Value;
    }

    public void updateLifeboard()
    {
        //TODO : update l'affichage des vies
    }
}
