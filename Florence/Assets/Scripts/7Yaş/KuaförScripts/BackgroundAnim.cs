using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundAnim : MonoBehaviour
{
    public Animator animator_kuaför,sahneGeçiþ;
    public Animator animator_saç1, animator_saç2;
    public bool z1, z2, z3;
    Butonlar buton;
    
    private void Start()
    {
         z1= true;
         z2= false;
         z3= false;
         
        buton = FindObjectOfType<Butonlar>();
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
            animator_saç1.SetBool("Saç1", true) ;
            animator_saç2.SetBool("Saç2", true) ;
            z2= false;
            z3= true;

        }
        else if (Input.GetMouseButtonDown(0) && z3 == true)
        {
            
            z3 = false;
            

        }
        else if (Input.GetMouseButtonDown(0) && buton.cam == true)
        {
            sahneGeçiþ.SetBool("Sahne", true);
            Invoke("SahneGeçiþ", 1.5f);


        }


    }
    private void SahneGeçiþ()
    {
        SceneManager.LoadScene(7);
    }
    
}
