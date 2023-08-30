using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI; // use this with legacy text

public class InteractiveItem : MonoBehaviour
{
    // variables created here creates a editable slots in the inspector for whatever GameOject has this script is attached
    public string itemName;
    public string itemDescription;
    public bool isInventoryItem;
    public static List<string> playerInventory = new List<string>();

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
    }


    public void DisplayInteractiveItemDetails()
    {
        // Update() is the place to handle the frame update for the GameObject  

        // this is the long way to do this but it works
        dynamicTitleName.GetComponent<UnityEngine.UI.Text>().text = itemName;
        dynamicTitleDescription.GetComponent<UnityEngine.UI.Text>().text = itemDescription;
        dynamicTitleIsInventoryItem.GetComponent<UnityEngine.UI.Text>().text = isInventoryItem.ToString();

        // you can also save these as variables to make things a little shorter like this...

        // Text tempTitle = dynamicTitleName.GetComponent<UnityEngine.UI.Text>();
        // tempTitle.text = itemName;

        // Text tempDescription = dynamicTitleName.GetComponent<UnityEngine.UI.Text>();
        // tempDescription.text = itemDescription;

        // Text tempIsInventoryItem = dynamicTitleName.GetComponent<UnityEngine.UI.Text>();
        // tempIsInventoryItem.text = isInventoryItem.ToString();
    }

    public void RemoveInteractiveItemDetails()
    {
        dynamicTitleName.GetComponent<UnityEngine.UI.Text>().text = " ";
        dynamicTitleDescription.GetComponent<UnityEngine.UI.Text>().text = " ";
        dynamicTitleIsInventoryItem.GetComponent<UnityEngine.UI.Text>().text = " ";
    }

    public void AddItemToInventory()
    {
        string itemToPush = dynamicTitleName.GetComponent<UnityEngine.UI.Text>().text;
        playerInventory.Add(itemToPush);

        for (int i = 0; i < playerInventory.Count; i++)
        {
            Debug.Log("playerInventory[i]: " + playerInventory[i]);
        }
    }
}
