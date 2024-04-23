using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = .05f; // Adjust this value to change player speed

    private Rigidbody2D rb;

    private Vector2 movement;

    private Animator animator;

    private bool isMoving;

    public LayerMask solidObjectsLayer;

    public LayerMask grassLayer;

    public int a = 1; //tracker variable used for debugging


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        Debug.Log("Start");
    }

    void Update()
    {
        //Movement + Animation Function
        if (!isMoving) //so the sprite does not return to default position also condition for movement
        {
            // Input
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            //diagonal movement not allowed
            if (movement.x != 0)
            {
                movement.y = 0;
            }

            if (movement != Vector2.zero)
            {

                //animation parameters
                animator.SetFloat("moveX", movement.x);
                animator.SetFloat("moveY", movement.y);

                //movement parameters
                var targetPos = transform.position;
                targetPos.y += movement.y;
                targetPos.x += movement.x;

                if (isWalkable(new Vector3(targetPos.x, targetPos.y - 0.5f)))
                {
                    StartCoroutine(Move(targetPos));
                }  
            }
        }
        animator.SetBool("isMoving", isMoving);
    }

    void FixedUpdate()
    {
        // Movement
        if (isMoving)
         {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
         }
    }

    IEnumerator Move (Vector3 targetPos)
    {
        isMoving = true;

        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;

        isMoving = false;

        CheckForEncounters();
    }

    private bool isWalkable(Vector3 targetPos)
    {
        if(Physics2D.OverlapCircle(targetPos, .1f, solidObjectsLayer) != null)
        {
            return false;
        }
        return true;
    }

    private void CheckForEncounters()
    {
        if (Physics2D.OverlapCircle(transform.position, .2f, grassLayer) != null)
        {
            if (UnityEngine.Random.Range(1, 101) <= 10)
            {
                Debug.Log("Encountered Wild Pokemon" + a);
                a = a + 1;
            }
        }
    }
}
