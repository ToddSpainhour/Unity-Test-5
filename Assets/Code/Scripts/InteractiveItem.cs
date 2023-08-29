using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // use this with legacy text

public class InteractiveItem : MonoBehaviour
{
    // variables created here creates a editable slots in the inspector for whatever GameOject has this script is attached
    public string itemName;
    public string itemDescription;
    public bool isInventoryItem;

    // creating these GameObject variables here also creates a slot back in Unity
    // with the purpose of connecting another GameObject to this variable
    // you do that by dragging the GameObject from the hierarchy to the empty slot
    public GameObject dynamicTitleName;
    public GameObject dynamicTitleDescription;
    public GameObject dynamicTitleIsInventoryItem;


    // Unity handles constructors on its own. Making constructors yourself will cause major problems

    void Start()
    {
        // Start() is useful to set upvariables, read preferences, and make connections with other GameObjects

        dynamicTitleName.GetComponent<UnityEngine.UI.Text>().text = itemName;
        dynamicTitleDescription.GetComponent<UnityEngine.UI.Text>().text = itemDescription;
        dynamicTitleIsInventoryItem.GetComponent<UnityEngine.UI.Text>().text = isInventoryItem.ToString();

    }


    public void DisplayInteractiveItemDetails()
    {
     // Update() is the place to handle the frame update for the GameObject  
    }
}
