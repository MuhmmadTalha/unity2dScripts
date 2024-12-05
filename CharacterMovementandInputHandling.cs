//Mini Project: Add jumping mechanics using Unity’s physics system (with Rigidbody and AddForce()).
using UnityEngine;

public class Script : MonoBehaviour
{
    // Private Variables
    private int jumpCount = 0;
    private Rigidbody2D rb;

    // Public Variables
    public float maxTime = 50f;
    public float timePassed = 0f;
    public float incSpeed = 10f;
    public float movSpeed = 10f;
    public float jumpPower = 10f;
    public int maxJumps = 2;

    void Start()
    {
        //Make sure to assign Player Rigidbody2D(dynamic) and BoxCollider2D
         rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //float vInp = Input.GetAxis("Vertical");
        float hInp = Input.GetAxis("Horizontal");

        //returns a bool value which we will use in if condition
        bool sJum = Input.GetButton("Jump");

        //Horizontal Movement
        rb.velocity = new Vector2(hInp * movSpeed, rb.velocity.y);

        //if condition to check if object is touching ground. Alternative ways are Ground Check with Raycasting, Collision Detection with Tags,  Unity's Rigidbody2D Collision Flags
        //Cuurently the double jump aint working ig i will have to use it through collison detection rather than velocity detection
        if (sJum && jumpCount < maxJumps) 
        {
            rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
            jumpCount++;
        }

        if(Mathf.Abs(rb.velocity.y) <0.01)
        {
            jumpCount = 0;
        }
    }
}
