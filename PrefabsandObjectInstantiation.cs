/*Learn to create prefabs in Unity and write code to spawn objects at runtime using Instantiate().
Set up a simple projectile system that launches objects in a specified direction.
Mini Project: Make a projectile launcher (e.g., press a key to shoot objects from a player character).
*/
using UnityEngine;

public class PrefabsandObjectInstantiation : MonoBehaviour
{
    public GameObject prefab;
    public float speed;
    private float fireRate = 0.5f; // Time between shots
    private float nextFireTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) 
        {
            // Instantiate the projectile at the position of the player
            GameObject projectile = Instantiate(prefab, transform.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();


            // Instantiate the prefab at a random horizontal position, with a fixed vertical position
            //Instantiate(prefab, new Vector2(Random.Range(-5f,5f), 1), Quaternion.identity);

            //Quaternion rotation = Quaternion.Euler(0, 0, angle); // Replace 'angle' with the desired rotation in degrees
            //Instantiate(prefab, transform.position, rotation);

            //if (Time.time >= nextFireTime && Input.GetKeyDown(KeyCode.X))
            //{
            //    nextFireTime = Time.time + fireRate;
            //    GameObject projectile = Instantiate(prefab, transform.position, Quaternion.identity);
            //    Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            //}

            rb.velocity = new Vector2(speed, 0); //Shoots to right
            //rb.velocity = new Vector2(speed, speed); //Shoots Diagnolly
            //rb.velocity = new Vector2(0, speed); //Shoots Upwards
            //rb.velocity = new Vector2(0, -speed); //Shoots Downwards


            Destroy(projectile, 5f); //Destroyes after 5 seconds



        }

    }
}
