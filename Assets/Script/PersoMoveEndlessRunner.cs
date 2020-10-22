using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersoMoveEndlessRunner : MonoBehaviour
{
    public float Speed = 1;
    
    Rigidbody rb;

    public float JumpFactor = 1;
    bool IsJumping = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float verticalVal = Input.GetAxis("Vertical");
        
        Vector3 posArrivee = transform.position + (Vector3.forward * Speed * Time.deltaTime * verticalVal);
        rb.MovePosition(posArrivee);

        float jumpVal = Input.GetAxis("Jump");
        if(jumpVal > 0.1f && !this.IsJumping){
            this.IsJumping = true;
            rb.AddForce(Vector3.up * this.JumpFactor, ForceMode.VelocityChange);
        }
    }

    public void HitGroud()
    {
        IsJumping = false;
    }
}
