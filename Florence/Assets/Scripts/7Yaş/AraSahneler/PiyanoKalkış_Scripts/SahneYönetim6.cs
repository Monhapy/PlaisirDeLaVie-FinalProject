using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneYönetim6 : MonoBehaviour
{
    [SerializeField] Animator resimm1, resimm2, resimm3;
    [SerializeField] bool pp1, pp2, pp3;
    void Start()
    {
        pp1 = true;
        pp2 = false;
        pp3 = false;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && pp1 == true)
        {
            resimm1.SetBool("Dönüşş1", true);
            Invoke("Animss1", 0.5f);
            pp1 = false;
            pp2 = true;

        }
        else if (Input.GetMouseButtonDown(0) && pp2 == true)
        {
            resimm2.SetBool("Dönüşş2", true);
            Invoke("Animss2", 0.5f);
            pp2 = false;
            pp3 = true;

        }
        else if (Input.GetMouseButtonDown(0) && pp3 == true)
        {
            resimm3.SetBool("Dönüşş3", true);
            StartCoroutine(SonGeçiişş());
            pp3 = false;


        }
        
    }
    IEnumerator SonGeçiişş()
    {
        //Sahne geçişi için gerekli olan delay
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(10);
    }
    private void Animss1()
    {
        //1.resim ile 2.resim arasındaki gerekli olan delay için yazılmış fonk
        resimm2.SetBool("Dönüşş1", true);
    }
    private void Animss2()
    {
        //2.resim ile 3.resim arasındaki gerekli olan delay için yazılmış fonk
        resimm3.SetBool("Dönüşş2", true);
    }
}
