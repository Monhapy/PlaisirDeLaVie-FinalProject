using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taşı : MonoBehaviour
{
    Camera kamera;
    Vector2 baslangic_pozisyon;

    GameObject[] kutu_dizisi;
    private void OnMouseDrag()
    {
        Vector3 pozisyon=kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }
    void Start()
    {
        kamera=GameObject.Find("Main Camera").GetComponent<Camera>();   
        baslangic_pozisyon = transform.position;
        kutu_dizisi = GameObject.FindGameObjectsWithTag("Kutu");
    }

    
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach(GameObject Kutu in kutu_dizisi) 
            {
                if (Kutu.name == gameObject.name) 
                { 
                    float mesafe = Vector3.Distance(Kutu.transform.position, transform.position);
                    if (mesafe <= 1)
                    {
                        transform.position= Kutu.transform.position;
                    }
                    else
                    {
                         transform.position=baslangic_pozisyon ;
                    }
                }
            }
        }
    }
}
