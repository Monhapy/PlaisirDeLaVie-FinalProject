using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundAnim : MonoBehaviour
{
    public Animator animator_kuaför,sahneGeçiþ;
    public Animator animator_saç1, animator_saç2;
    public bool z1, z2,z3,z4;
    private void Start()
    {
         z1= true;
         z2= false;
         z3= false;
         z4= false;
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
            z4 =true;

        }
        else if (Input.GetMouseButtonDown(0) && z4 == true)
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
