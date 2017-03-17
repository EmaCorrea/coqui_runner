using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    bool doubleJump = false;

    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D myRigidBody;

    public bool grounded;
    public LayerMask whatIsGround;

    private Collider2D myCollider;
    private Animator myAnimator;

	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        myAnimator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if(transform.position.y < -5.0f)
        {
            Debug.Log("Dead");
        }

        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
        if(grounded)
        {
            doubleJump = false;
        }

        myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if(grounded)
            {
                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce);
            }
           else  if (!doubleJump)
            {
                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce);
                doubleJump = true;
            }      
        }

        myAnimator.SetFloat("Speed", myRigidBody.velocity.x);
        myAnimator.SetBool("Grounded", grounded);
    }

}
