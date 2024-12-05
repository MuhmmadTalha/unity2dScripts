//Create a player that collects coins or items and displays the count on the UI.
//Attach this script to your Player
using UnityEngine;
using UnityEngine.UI; // Using Legacy Unity Text 

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rb;

    public  int coinCount;
    public Text coinCountText; //Make sure to drag and drop your canvas text to pass the object in your Unity Editor Hierarchy
  
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        UpdateCoinCountText();
    }

    // Update is called once per frame
    void Update()
    {
        //Empty
    }

    void UpdateCoinCountText()
    {
        coinCountText.text = "Coin Count: " + coinCount.ToString();
        //coinCount.ToString(); - converts  converting the coinCount integer value into a string representation.
        //This is necessary because the Text or TextMeshProUGUI components expect a string type for their text property, and coinCount is an int.
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Make sure isTrigger is turned on of the object tagged "Coin"

        if (other.gameObject.CompareTag("Coin"))
        {
            UpdateCoinCountText();
            coinCount++;
            Destroy(other.gameObject);

            //Optional to check in console too
            //Debug.Log("Coin has been destroyed"); 
            //Debug.Log("Coin Count: " + coinCount);
         
        } 
    }
}
