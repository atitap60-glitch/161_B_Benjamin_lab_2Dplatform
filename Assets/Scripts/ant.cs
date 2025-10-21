using UnityEngine;
using UnityEngine.UI;

public class ant : enemy
{
    [SerializeField] public Vector2 velocity;
    public Transform[] movePath;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(20);
        DamageHit = 20;
        velocity = new Vector2(-1.0f , 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //behavior
    private void FixedUpdate()
    {
        behavior();
    }
    public override void behavior()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        if (velocity.x < 0 && rb.position.x <= movePath[0].position.x)
        {
            Flip();
        }
        if (velocity.x > 0 && rb.position.x >= movePath[1].position.x)
        {
            Flip();
        }
    }
    public void Flip()
    {
        velocity.x *= -1;      
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


}
