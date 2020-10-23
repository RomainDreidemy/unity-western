using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateUVOffset : MonoBehaviour
{
    Renderer rend;
    Global globalRef;

    public float Mult = 1;

    // Start is called before the first frame update
    void Start()
    {
        this.rend = GetComponent<Renderer>();
        globalRef = FindObjectOfType<Global>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = this.rend.material.GetTextureOffset("_MainTex");
        offset.x +=  this.Mult * this.globalRef.Speed * Time.deltaTime;

        this.rend.material.SetTextureOffset("_MainTex", offset);
    }
}
