using UnityEngine;

public class croc : enemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(150);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void behavior()
    {
        throw new System.NotImplementedException();
    }
}
