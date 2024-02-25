using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Walking : MonoBehaviour
{
    //varables and other neccary things for the code
    Rigidbody2D rb;
    Animator animator;
    Vector2 destination;
    Vector2 movement;
    public float speed = 2.5f;

    //set states for bools to false
    public bool right;
    public bool left;
    public bool back;

    void Start()
    {
        //gathring components
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        back = false;
        right = false;
        left = false;
    }
    private void FixedUpdate()
    {
        //Movement for the player
        movement = destination - (Vector2)transform.position;
        if (movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }
        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        //input so the player can move on mouse click
        if(Input.GetMouseButtonDown(0))
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        //identifies the movement in animator.
        animator.SetFloat("Movement", movement.magnitude);

        //chnages the state of the animator sprite when button is down changes it back to noraml when the button is up
        if (Input.GetKeyDown(KeyCode.B))
        {
            animator.SetBool("Back", true);
        }
        else if (Input.GetKeyUp(KeyCode.B))
        {
            animator.SetBool("Back", false);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetBool("Right", true);
        }
        else if(Input.GetKeyUp(KeyCode.R))
        {
            animator.SetBool("Right", false);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            animator.SetBool("Left", true);
        }
        else if (Input.GetKeyUp(KeyCode.L))
        {
            animator.SetBool("Left", false);
        }
    }

}
