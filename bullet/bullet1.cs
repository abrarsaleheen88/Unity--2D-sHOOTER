using UnityEngine;

public class bullet : MonoBehaviour
{
    //step2
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int speed =10;//speed of bullet
    Rigidbody2D rb;// Reference to the Rigidbody2D component
    void Start()
    {
        //step2
        rb= GetComponent<Rigidbody2D>();// Get the Rigidbody2D component attached to the bullet
        rb.linearVelocity = transform.right * speed; // Move the bullet in the direction it is facing - right direction is the 
        // direction of the bullet
        Destroy(gameObject, 2f); // Destroy the bullet after 2 seconds to prevent it from existing indefinitely
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
