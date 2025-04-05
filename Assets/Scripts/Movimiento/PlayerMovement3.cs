using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement3 : MonoBehaviour
{
  [SerializeField] private float speed = 3f;
  private Rigidbody2D rb;
  private Vector2 moveInput;

  [SerializeField] private float leftLimit;
  [SerializeField] private float rightLimit;
  [SerializeField] private float bottomLimit;
  [SerializeField] private float topLimit;


  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }


  void Update()
  {
    float moveX = Input.GetAxis("Horizontal");
    float moveY = Input.GetAxis("Vertical");
    moveInput = new Vector2(moveX, moveY).normalized;
  }


  void FixedUpdate()
  {
    rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
    transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftLimit, rightLimit), Mathf.Clamp(transform.position.y, bottomLimit, topLimit), transform.position.z);
  }
}

