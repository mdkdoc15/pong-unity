using System;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField]
    private bool isPlayer1 = true;

    [SerializeField]
    private float speed = 5;

    private float movement;

    private Rigidbody2D rb;

    private Vector3 startPos;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        if (isPlayer1)
            movement = Input.GetAxisRaw("Vertical");
        else
            movement = Input.GetAxisRaw("Vertical2");

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
    
    public void Reset()
    {
        transform.position = startPos;
        rb.velocity = Vector2.zero;
    }
}