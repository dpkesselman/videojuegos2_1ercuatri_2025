using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    private float speed = 8f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float JumpForce = 6f;

    // Double Jump
    [SerializeField] private int nJumps = 1;
    private int nJumpsValue;
   
    void FixedUpdate() // Estamos trabajando toqueteando físicas del Player, entonces usamos el Fixed Update
    {
        float h = Input.GetAxis("Horizontal");
        
        rb.transform.Translate(new Vector2(h, 0) * Time.deltaTime * speed);
       
        if (Input.GetKeyDown(KeyCode.Space) && nJumpsValue > 0)
        {
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            nJumpsValue--;
        }


        if (JumpCollider.isGrounded)
        {
            nJumpsValue = nJumps;
        }     
    }
}

