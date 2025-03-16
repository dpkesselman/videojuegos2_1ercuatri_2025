using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement2 : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    [SerializeField] private Rigidbody2D rb;


    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
}

