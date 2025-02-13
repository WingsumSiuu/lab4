using UnityEngine;

public class charwalk : MonoBehaviour
{
    public Rigidbody2D body;
    // private GameObject aria;
    public Animator animate;
    private float horizontal;
    private float speed = 5f;
    private bool facingRight = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // aria = GameObject.Find("aria");
        animate = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        if (Mathf.Abs(xInput) > 0) {
            body.linearVelocity = new Vector2(xInput*speed, body.linearVelocity.y);

            // -1 left, 1 right (flips aria as needed)
            // float direction = Mathf.Sign(xInput);
            // transform.localScale = new Vector3(direction, 1, 1);
        }
        if (Mathf.Abs(yInput) > 0) {
            body.linearVelocity = new Vector2(body.linearVelocity.y, yInput*speed);
        }

        if (body.linearVelocity.x != 0 || body.linearVelocity.y != 0) {
            animate.SetBool("iswalking", true);
        } else {
            animate.SetBool("iswalking", false);
        }
    }

}

