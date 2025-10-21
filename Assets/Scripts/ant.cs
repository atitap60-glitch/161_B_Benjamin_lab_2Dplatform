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
        velocity = new Vector2(-1.0f,0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void behavior()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        if (velocity.x < 0 && rb.position.x <= movePath[0].position.x)
        {
            
        }
    }
}
