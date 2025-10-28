using UnityEngine;

public class PlayerController : Character
{
    public float maxSpeed = 10f;
    public float jumpForce = 300f;

    bool facingRight = true;
    Rigidbody2D r2d;
    Animator anim;

    [Header("Ground Check")]
    public bool grounded = false;
    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        if (groundCheck == null)
            Debug.LogError("groundCheck not assigned!");
    }

    void Update()
    {
        // Jump input
        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        // Ground check
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", grounded);
        anim.SetFloat("vSpeed", r2d.linearVelocity.y);

        // Horizontal movement
        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(move));

        // Better: Use velocity for smooth control, but don't touch Y during jump
        Vector2 velocity = r2d.linearVelocity;
        velocity.x = move * maxSpeed;
        r2d.linearVelocity = velocity;

        // Flip sprite
        if (move > 0 && !facingRight) Flip();
        else if (move < 0 && facingRight) Flip();
    }

    void Jump()
    {
        anim.SetBool("Ground", false);
        r2d.AddForce(new Vector2(0, jumpForce));
        grounded = false; // Prevent double jump
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    // Optional: Visualize ground check in editor
    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = grounded ? Color.green : Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, groundRadius);
        }
    }
}