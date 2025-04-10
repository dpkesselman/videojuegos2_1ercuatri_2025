using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump2 : MonoBehaviour
{
    private float speed = 8f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float JumpForce = 8f;

    //Animation
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update ()
    {
        float h = Input.GetAxis("Horizontal");


        rb.transform.Translate(new Vector2(h, 0) * Time.deltaTime * speed);
        animator.SetFloat("moveX", Mathf.Abs(h));
       
        if (Input.GetKeyDown(KeyCode.Space) && JumpCollider.isGrounded == true)
        {
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }        
    }
}

