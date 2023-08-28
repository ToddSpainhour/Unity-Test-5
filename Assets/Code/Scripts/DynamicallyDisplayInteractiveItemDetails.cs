using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicallyDisplayInteractiveItemDetails : MonoBehaviour
{
    public GameObject dynamicItemName;

    public string itemName;

    Text itemName_text;

    public void DynamicallyDisplayItemName()
    {
        Debug.Log("DynamicallyDisplayItemName just ran!!");

        itemName_text = dynamicItemName.GetComponent<Text>();
        itemName_text.text = "how to make this the item's name?";
    }
}
