using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to change player speed

    private Rigidbody2D rb;

    private Vector2 movement;

    private Animator animator;

    private bool isMoving = false;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Input
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        //Movement + Animation Function
        if (moveX != 0 || moveY != 0) //so the sprite does not return to default position also condition for movement
        {
            // Prevent diagonal movement
            if (moveX != 0 && moveY != 0)
            {
                moveY = 0;
            }

            movement = new Vector2(moveX, moveY).normalized;

            //Animation Parameters
            animator.SetFloat("moveX", movement.x);
            animator.SetFloat("moveY", movement.y);

            isMoving = true;
            animator.SetBool("isMoving", isMoving);
        }
        else
        {
            isMoving = false;
            animator.SetBool("isMoving", isMoving);
        }
    }

    void FixedUpdate()
    {
        // Movement
        if (isMoving)
         {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
         }
    }
}
