using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket2 : MonoBehaviour
{
	private Rigidbody2D rb;
	private float moveInput;
	private bool isGrounded;
	
	public float speed;
	public float jumpForce;
	public float checkRadius;
	public Transform groundCheck;
	public LayerMask whatIsGround;
	
	
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

	
	void FixedUpdate()
	{
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
		
		moveInput = Input.GetAxis("Vertical");
		rb.velocity = new Vector2(rb.velocity.x, moveInput * speed);
	}
	
	
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			rb.velocity = Vector2.up * jumpForce;
		}
    }
}
