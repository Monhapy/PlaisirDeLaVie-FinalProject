using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaydırma : MonoBehaviour
{
    //farkı bulmaya yarayan değişken
    Vector2 fark = Vector2.zero;
    

    private void OnMouseDown()
    {
        //nesne ile mouse arasındaki göreli fark vector olarak
        fark = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }
    private void OnMouseDrag()
    {
        //basılı tutulduğunda bu farkı mousedan çıkararak obje ile mouse konumlarını eşitliyor mouse nereye obje oraya
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - fark;
        
    }
}
