using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    private float moveSpeedStore;
    public float jumpForce;

    public float speedMultiplier;

    public float speedIncreaseMilestone;
    private float speedIncreaseMilestoneStore;

    private float speedMilestoneCount;
    private float speedMilestoneCountStore;

    bool canDoubleJump = true;

    private Rigidbody2D myRigidBody;

    public bool grounded;
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public float groundCheckRadius;

    private Collider2D myCollider;
    private Animator myAnimator;

    public GameManager theGameManager;
    public PowerupManager thePowerupManager;
    public BackgroundScroller theBackgroundScroller;

    public AudioSource jumpSound;
    public AudioSource deathSound;

	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();

        speedMilestoneCount = speedIncreaseMilestone;

        moveSpeedStore = moveSpeed;
        speedIncreaseMilestoneStore = speedIncreaseMilestone;
        speedMilestoneCountStore = speedMilestoneCount;

        jumpSound.volume = 0.1f;
        deathSound.volume = 0.1f;
    }
	
	// Update is called once per frame
	void Update () {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        if(transform.position.x > speedMilestoneCount && moveSpeed <= 12)
        {
            speedMilestoneCount += speedIncreaseMilestone;
            moveSpeed = moveSpeed * speedMultiplier;
        }

        if(grounded)
        {
            canDoubleJump = true;
        }

        myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if(grounded)
            {
                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce);
                jumpSound.Play();
            }
            else if(canDoubleJump)
            {
                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce);
                jumpSound.Play();
                canDoubleJump = false;
            }      
        }

        myAnimator.SetFloat("Speed", myRigidBody.velocity.x);
        myAnimator.SetBool("Grounded", grounded);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Killbox")
        {
            theBackgroundScroller.StopScrolling();
            theGameManager.RestartGame();
            thePowerupManager.StopPowerup();
            moveSpeed = moveSpeedStore;
            speedMilestoneCount = speedMilestoneCountStore;
            speedIncreaseMilestone = speedIncreaseMilestoneStore;
            deathSound.Play();
        }
    }

}
