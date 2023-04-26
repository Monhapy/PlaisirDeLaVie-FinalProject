using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaydırma : MonoBehaviour
{
    Vector2 fark = Vector2.zero;
    

    private void OnMouseDown()
    {
        fark = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }
    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - fark;
        
    }
}
