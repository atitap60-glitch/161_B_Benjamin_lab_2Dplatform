using UnityEngine;

public abstract class enemy : Character
{
    public int DamageHit { get; protected set; }
    public abstract void behavior();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
