using UnityEngine;

public class charwalk : MonoBehaviour
{
    // Largely following tutorial: https://www.youtube.com/watch?v=0-c3ErDzrh8

    public Rigidbody2D body;
    // private GameObject aria;
    public Animator animate;
    private float groundSpeed = 5f;
    private float jumpSpeed = 5f;
    private float groundDecay = 0.8f;
    public BoxCollider2D groundCheck;
    private float acceleration = 0.2f;
    public LayerMask groundMask;
    public bool grounded;
    private float xInput;
    private float yInput;
    public AudioSource source;
    public AudioClip dirtSound;

    void Start() {
        source = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        checkInput();
        handleJump();
    }

    void FixedUpdate()
    {
        checkGround(); 
        handleXMovement();
        applyFriction();
        animove();
    }

    void checkInput() {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }

    void handleXMovement() {
        if (Mathf.Abs(xInput) > 0) {
            float increment = xInput*acceleration;
            float newSpeed = Mathf.Clamp(body.linearVelocity.x + increment, -groundSpeed, groundSpeed);
            body.linearVelocity = new Vector2(newSpeed, body.linearVelocity.y);

            // -1 left, 1 right (flips aria as needed)
            float direction = Mathf.Sign(xInput);
            transform.localScale = new Vector3(direction, 1, 1);

            if (!source.isPlaying) {
                source.Play();
            } 
        } 
    }

    void handleJump() {
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

