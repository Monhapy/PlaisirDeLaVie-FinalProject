using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KalemDüsürme : MonoBehaviour
{
    [SerializeField] private Animator resim1, resim2, resim3,camAnims, buton;
    public bool p1,p2, p3;
    public GameObject butons;
    private void Start()
    {
        p1 = true;
        p2= false;
        p3= false;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)&& p1==true)
        {
            resim2.SetBool("Geliş2", true);
            p1= false;
            p2= true;
        }
        else if (Input.GetMouseButtonDown(0) && p2 == true)
        {
            resim3.SetBool("Geliş3", true);
           
            Invoke("ButonAkitflik", 2f);
            p2 = false;
            p3= true;

        }
        else if (Input.GetMouseButtonDown(0) && p3 == true)
        {
            camAnims.SetBool("CamMove", true);
            
        }
    }
    
}
