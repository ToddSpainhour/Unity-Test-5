using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveItem : MonoBehaviour
{

    /*
     * if you assign a GameObject this C# script in Unity, 
     * it makes the properties below show up as fillable textboxes in that GameObject's inspector.
     * there you can assign the values (like the key in this example) 
     */
    public string itemName;
    public string itemDescription;
    public bool isInventoryItem;

    // this let's you reach back into Unity to interact with variables there like the properties above; it's find finding a control
    public GameObject interactiveItemKey;

    // 
    public void DisplayInteractiveItemDetails()
    {
        // reassign one of the UI variables to be the items details
        Debug.Log("you hovered over an interactive item");

        InteractiveItem key = interactiveItemKey.GetComponent<InteractiveItem>();

        Debug.Log("key.itemName " + key.itemName);
        Debug.Log("key.itemDescription " + key.itemDescription);
        Debug.Log("key.isInventoryItem " + key.isInventoryItem);
    }
}
