using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    SpriteRenderer sr;
    Rigidbody2D rb;
    public Color selectColor;
    public Color unSelectedColor;
    public Sprite sprite;
    public float speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        Selected(false);
    }

    private void OnMouseDown()
    {
        Controller.SetSelectedPlayer(this);
    }

    public void Selected(bool isSelected)
    {
        if (isSelected)
        {
            sr.color = selectColor;
        }
        else
        {
            sr.color = unSelectedColor;
        }
    }

    public void Move(Vector2 direction)
    {
        rb.AddForce(direction * speed, ForceMode2D.Impulse);
    }
}
