using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement3 : MonoBehaviour
{
  [SerializeField] private float speed = 3f;
  private Rigidbody2D rb;
  private Vector2 moveInput;
  private Animator animator;
  //private SpriteRenderer renderer;
  private bool facingRight = true;
  float moveX;
  float moveY;

  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    animator = GetComponent<Animator>();
    //renderer = GetComponent<SpriteRenderer>();
  }


  void Update()
  {
    moveX = Input.GetAxis("Horizontal");
    moveY = Input.GetAxis("Vertical");
    moveInput = new Vector2(moveX, moveY).normalized;
    rb.MovePosition(rb.position + moveInput * speed * Time.deltaTime);
    Flip();
    animator.SetFloat("moveX", Mathf.Abs(moveX));
    animator.SetFloat("moveY", Mathf.Abs(moveY));
  }

  /*private void Flip() // Usando el flip del renderer
  {
    if (moveX < 0)
    {
      renderer.flipX = true;
    }
    else if (moveX > 0)
    {
      renderer.flipX = false;
    }
  }*/

  private void Flip() // usando rotación del asset
  {
    if (moveX < 0 && facingRight || moveX > 0 && !facingRight)
    {
      facingRight = !facingRight;
      transform.Rotate(new Vector3(0,180,0));
    }
  }

}

