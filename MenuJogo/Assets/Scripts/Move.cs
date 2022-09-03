using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb;
    public int moveSpeed;
    private float direction;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(direction,rb.velocity.y);
    }
}
