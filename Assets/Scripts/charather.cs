using UnityEngine;

public abstract class charather : MonoBehaviour
{
    private int health;
    private int Health 
    { 
        get { return health; }
        set { health = (value < 0) ? 0 : value; }
    }

    protected Animator Anim;
    protected Rigidbody2D rb;

    public void Initialize(int startHealth)
    { 
        health = startHealth;
        Debug.Log($"{this.name} health : {this.health}");

        Anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log($"{this.name} ouch . . {damage} || health remain {Health}");
        
    }

    public bool isDead()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            return false;
        }
        else { return false; }
    }

        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
