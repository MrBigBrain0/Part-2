using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    Vector2 destination;
    Vector2 movement;
    public float speed = 3f;
    bool clickOnSelf = false;
    public float health;
    public float MaxHealth = 5;
    bool isDead;
    public HealthBar healthBar;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        healthBar = GetComponent<HealthBar>();
        health = MaxHealth;
        isDead = false;
    }

    private void FixedUpdate()
    {
        if (isDead) return;
        movement = destination - (Vector2)transform.position;
        if(movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }
        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);

        if (Input.GetMouseButton(1))
        {
            animator.SetTrigger("Attack");
        }

    }
    void Update()
    {
        if (isDead) return;
        if (Input.GetMouseButtonDown(0) && !clickOnSelf)
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        animator.SetFloat("Movement", movement.magnitude);
    }

    private void OnMouseDown()
    {
        if (isDead) return;
        clickOnSelf = true;
        gameObject.SendMessage("TakeDamage", 1, SendMessageOptions.DontRequireReceiver);
    }

    private void OnMouseUp()
    {
        clickOnSelf = false;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        health = Mathf.Clamp(health,0,MaxHealth);
        if(health <= 0)
        {
            isDead = true;
            animator.SetTrigger("Death");
        }
        else
        {
            isDead = false;
            animator.SetTrigger("TakeDMG");
        }
    }

}
