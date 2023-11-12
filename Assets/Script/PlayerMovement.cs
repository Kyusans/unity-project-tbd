using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    Rigidbody2D rb;
    Vector2 moveDirection;
    
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        InputManagement();
    }

    void FixedUpdate() {
        Move();
    }

    void InputManagement(){
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(horizontal, vertical).normalized;
    }

    void Move(){
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
