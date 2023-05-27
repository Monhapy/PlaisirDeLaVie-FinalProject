using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneYönetim_5 : MonoBehaviour
{
    [SerializeField] Animator resim1, resim2, resim3;
    [SerializeField] bool p1,p2,p3;

    private void Awake()
    {
        p1 = true;
        p2 = false;
        p3 = false; 
         
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && p1 == true)
        {
            resim1.SetBool("Dönüş1", true);
            Invoke("Anims1", 0.5f);
            p1 = false;
            p2 = true;

        }
        else if (Input.GetMouseButtonDown(0) && p2 == true)
        {
            resim2.SetBool("Dönüş2", true);
            Invoke("Anims2", 0.5f);
            p2 = false;
            p3 = true;

        }
        else if (Input.GetMouseButtonDown(0) && p3 == true)
        {
            resim3.SetBool("Dönüş3", true);
            StartCoroutine(SonGeçişş());
            p3 = false;
            

        }
    }
    IEnumerator SonGeçişş()
    {
        //Sahne geçişi için gerekli olan delay
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(8);
    }
    private void Anims1()
    {
        //1.resim ile 2.resim arasındaki gerekli olan delay için yazılmış fonk
        resim2.SetBool("Dönüş1", true);
    }
    private void Anims2()
    {
        //2.resim ile 3.resim arasındaki gerekli olan delay için yazılmış fonk
        resim3.SetBool("Dönüş2", true);
    }
    
}
