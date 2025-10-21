using UnityEngine;

public class Player : Character
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(100);
    }

    public void onhitwith(enemy enemy)
    {
        TakeDamage(enemy.DamageHit);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        enemy enemy = other.gameObject.GetComponent<enemy>();
        if (enemy != null)
        { 
            onhitwith(enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
