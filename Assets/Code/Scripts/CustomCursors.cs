using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursors : MonoBehaviour
{

    public Texture2D cursorPlusSign;
    public Texture2D cursorCircle;

    
    void Start()
    {
        Debug.Log("CustomCursors script just started");
        Cursor.SetCursor(cursorPlusSign, Vector2.zero, CursorMode.ForceSoftware);
    }

    
    void Update()
    {
        // this worked
        //Cursor.visible = false;
    }

    public void OnInteractiveItemCursorEnter()
    {
        // change cursor to circle
        Debug.Log("CustomCursors OnInteractiveItemCursorEnter method");
        Cursor.SetCursor(cursorCircle, Vector2.zero, CursorMode.Auto);
    }

    public void OnInteractiveItemCursorExit()
    {
        // auto or force??
        Debug.Log("CustomCursors OnInteractiveItemCursorExit method");
        Cursor.SetCursor(cursorPlusSign, Vector2.zero, CursorMode.ForceSoftware);
    }
}
