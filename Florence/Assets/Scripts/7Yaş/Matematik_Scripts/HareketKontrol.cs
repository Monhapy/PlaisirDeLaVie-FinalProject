using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKontrol : MonoBehaviour
{
    public GameObject objectToDrag;
    public GameObject objectDragToPos;
    public float denemeSayi = 0;

    public float dropDistance;

    public bool isLocked;

    Vector2 objectInitPos;

    void Start()
    {
       objectInitPos=objectToDrag.transform.position;
    }

    
    public void DragObject()
    {
        if(!isLocked)
        {
            objectToDrag.transform.position= Input.mousePosition;
        }
    }
    public void DropObject()
    {
        float Distance = Vector3.Distance(objectToDrag.transform.position,objectDragToPos.transform.position);
        if(Distance < dropDistance) 
        {
            isLocked= true;
            objectToDrag.transform.position= objectDragToPos.transform.position;
            denemeSayi = denemeSayi + 1;
        }
        else
        {
            objectToDrag.transform.position = objectInitPos;
        }
    }
}
