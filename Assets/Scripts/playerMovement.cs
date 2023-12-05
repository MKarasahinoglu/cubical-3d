using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement: MonoBehaviour
{
    
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    public float jumpForce = 300f;
    public bool canJump = true;
	public Vector3 initialPosition;
    
	void Start()
    {
		initialPosition = transform.position;
	}

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);
        
        if(Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            
        }
        if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            
        }
        //Optional Jump Feature
        //if (Input.GetKey(KeyCode.Space) && canJump)
        //{
        //    rb.AddForce(0, jumpForce, 0, ForceMode.VelocityChange);
        //    canJump = false;
        //}

        if (transform.position.y<=-1)
        {
            GameManager.gameManager.EndGame();
        }
    }
}
