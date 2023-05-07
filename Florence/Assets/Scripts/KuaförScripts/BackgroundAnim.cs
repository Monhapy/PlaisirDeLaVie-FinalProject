using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAnim : MonoBehaviour
{
    public Animator animator_kuaför;
    public Animator animator_saç1, animator_saç2;
    public bool z1, z2;
    private void Start()
    {
         z1= true;
         z2= false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && z1==true)
        {
           
            animator_kuaför.SetBool("Geçme3", true);
            z1= false;
            z2= true;


        }
        else if(Input.GetMouseButtonDown(0) && z2 == true)
        {
            animator_saç1.SetBool("Saç1", true); ;
            animator_saç2.SetBool("Saç2", true) ;
            z2= false;

        }
    }
    
}
