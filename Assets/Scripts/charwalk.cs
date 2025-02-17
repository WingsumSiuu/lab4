using UnityEngine;

public class charwalk : MonoBehaviour
{
    // Largely following tutorial: https://www.youtube.com/watch?v=0-c3ErDzrh8

    public Rigidbody2D body;
    // private GameObject aria;
    public Animator animate;
    private float groundSpeed = 5f;
    private float jumpSpeed = 3f;
    private float groundDecay = 0.2f;
    public BoxCollider2D groundCheck;
    public LayerMask groundMask;
    public bool grounded;
    private float xInput;
    private float yInput;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
    }

    void FixedUpdate()
    {
        checkGround(); 
        applyFriction();
        inputMove();
        animove();
    }

    void getInput() {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }

    void inputMove() {
        if (Mathf.Abs(xInput) > 0) {
            body.linearVelocity = new Vector2(xInput*groundSpeed, body.linearVelocity.y);

            // -1 left, 1 right (flips aria as needed)
            float direction = Mathf.Sign(xInput);
            transform.localScale = new Vector3(direction, 1, 1);
        }
        if (Mathf.Abs(yInput) > 0 && grounded) {
            body.linearVelocity = new Vector2(body.linearVelocity.x, yInput*jumpSpeed);
        }

    }

    void animove() {
        if (xInput != 0 || yInput != 0) {
            animate.SetBool("iswalking", true);
        } else {
            animate.SetBool("iswalking", false);
        }
    }

    void checkGround() {
        grounded = Physics2D.OverlapAreaAll(groundCheck.bounds.min, groundCheck.bounds.max, groundMask).Length > 0;
    }

    void applyFriction() {
        if (grounded && xInput == 0 && yInput == 0) {
            body.linearVelocity *= groundDecay;
        }
    }
    
}

