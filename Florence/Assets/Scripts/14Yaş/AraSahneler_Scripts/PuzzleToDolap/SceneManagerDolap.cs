using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerDolap : MonoBehaviour
{
    // Her resim için animatorlerin çekilmesi

    [SerializeField] Animator resim_1_animator;
    [SerializeField] Animator resim_2_animator;
    [SerializeField] Animator resim_3_animator;
    [SerializeField] Animator cam_animator;


    // Hangi animasyonun neyden sonra oynayacaðýnýn kontrolü için deðiþkenler
    [SerializeField] bool z1, z2, z3;

    private void Awake()
    {
        //Deðiþkenlerin baþlangýç deðerleri
        z1 = true;
        z2 = false;
        z3 = false;


    }
    private void Update()
    {


        //1.resimin animasyon kodu
        if (Input.GetMouseButtonDown(0) && z1 == true)
        {
            resim_1_animator.SetBool("Geçiþ1", true);
            Invoke("Anim1", 0.5f);

            z1 = false;
            z2 = true;


        }
        //2.resimin animasyon kodu
        else if (Input.GetMouseButtonDown(0) && z2 == true)
        {
            resim_2_animator.SetBool("Geçiþ2", true);
            Invoke("Anim2", 0.5f);

            z2 = false;
            z3 = true;


        }
        //3. resimin animasyon kodu 
        else if (Input.GetMouseButtonDown(0) && z3 == true)
        {
            cam_animator.SetBool("CamZoom", true);
            Invoke("Anim3", 3f);
            StartCoroutine(SonGeçiþ());

            z3 = false;



        }



    }
    IEnumerator SonGeçiþ()
    {
        //Sahne geçiþi için gerekli olan delay
        yield return new WaitForSeconds(6f);

        SceneManager.LoadScene(16);
    }
    private void Anim1()
    {
        //1.resim ile 2.resim arasýndaki gerekli olan delay için yazýlmýþ fonk
        resim_2_animator.SetBool("Geçiþ1", true);
    }
    private void Anim2()
    {
        //2.resim ile 3.resim arasýndaki gerekli olan delay için yazýlmýþ fonk
        resim_3_animator.SetBool("Geçiþ2", true);
    }
    private void Anim3()
    {
        resim_3_animator.SetBool("Geçiþ3", true);
    }
}
