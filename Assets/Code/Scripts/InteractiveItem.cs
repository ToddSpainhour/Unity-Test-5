using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // use this with legacy text

public class InteractiveItem : MonoBehaviour
{
    
    // this let's you reach back into Unity to interact with variables there like the properties below; it's find finding a control
    // UI Text GameObjects
    public GameObject interactiveItemKey;
    //public GameObject dynamicItemNameHello; 


    // Game Variables
    public string itemName;
    public string itemDescription;
    public bool isInventoryItem;


    // Text Component
    //Text dynamicItemName;

    void Start()
    {
        
    }


    // 
    public void DisplayInteractiveItemDetails()
    {
        //dynamicItemName = dynamicItemNameHello.GetComponent<Text>();

        InteractiveItem key = interactiveItemKey.GetComponent<InteractiveItem>();
        Debug.Log("key.itemName " + key.itemName);
        Debug.Log("key.itemDescription " + key.itemDescription);
        Debug.Log("key.isInventoryItem " + key.isInventoryItem);
    }

    // reassign one of the UI variables to be the items details
    //Debug.Log("you hovered over an interactive item");

    // this just initializes the component??
    // Debug.Log("itemName_text.text: " + itemName_text.text);


    /*
    * if you assign a GameObject this C# script in Unity, 
    * it makes the properties below show up as fillable textboxes in that GameObject's inspector back in Unity.
    * there you can assign the values (like the key in this example) 
    */
}
