using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 Direction;

    //private Global GlobalRef; // Object with global script

    // Start is called before the first frame update
    void Start()
    {
        //this.GlobalRef = GameObject.FindObjectOfType<Global>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(this.GlobalRef.Speed * Direction * Time.deltaTime);
    }
}
