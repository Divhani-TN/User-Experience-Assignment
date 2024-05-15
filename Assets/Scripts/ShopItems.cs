using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItems : MonoBehaviour
{

    public int cost; // This can be set in the inspector
    public ShopManager shopManager; // Reference to the ShopManager script
    public Text gameText; // Reference to a UI Text component
    public BagManager bagManager;
    public Transform bagTransform;
    void OnMouseDown()
    {
        // Check if there is enough money to buy the item
        if (shopManager.moneyBalance >= cost)
        {
            // Deduct the cost from the money balance
            shopManager.moneyBalance -= cost;

            // Instantiate the item to the bag
            // You'll need to replace 'bagTransform' with the actual Transform of your bag
            Instantiate(gameObject, bagTransform.position, bagTransform.rotation);

            // Update the game text
            gameText.text = "Item bought successfully!";
        }
        else
        {
            // Update the game text
            gameText.text = "Not enough money to buy this item.";
        }
    }
}
