using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silme : MonoBehaviour
{
    [SerializeField] GameObject mask;
    [SerializeField] bool pressed;
    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;



        if (Input.GetMouseButtonDown(0))
        {
            pressed = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            pressed = false;
        }
        else if (pressed == true)
        {
            GameObject ob = Instantiate(mask, pos, Quaternion.identity);
            ob.transform.parent = GameObject.Find("scratch").transform;
        }


    }

}
