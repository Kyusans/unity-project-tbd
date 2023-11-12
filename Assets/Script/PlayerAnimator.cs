using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    PlayerMovement playerMovement;
    SpriteRenderer spriteRenderer;
    
    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerMovement = GetComponent<PlayerMovement>();    
    }

    void Update() {
        CheckSpriteDirection();    
    }

    void CheckSpriteDirection(){
        float horizontalInput = playerMovement.GetHorizontalInput();
        FlipSpriteDirection(horizontalInput);

    }

    void FlipSpriteDirection(float horizontalInput){
        if(horizontalInput < 0){
            spriteRenderer.flipX = true;
        }else if(horizontalInput > 0){
            spriteRenderer.flipX = false;
        }
    }
}
