using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour   //여긴 키압이 너무 높아. 살려줘ㅓㅓ 내 손가락 근육이 늘어난다~~
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float jumpForce = 4.0f;
    public float movespeed = 4.0f;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame  
    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        Vector2 movedirection = new Vector2(horizontalinput*movespeed,rb.velocity.y);
        rb.velocity = movedirection;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            jump();
        }
        if (collision.gameObject.CompareTag("ground1"))
        {
            jump1();
        }
    }
    
    void jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    void jump1()
    {
        rb.velocity = Vector2.up * jumpForce*3;
    }
}
