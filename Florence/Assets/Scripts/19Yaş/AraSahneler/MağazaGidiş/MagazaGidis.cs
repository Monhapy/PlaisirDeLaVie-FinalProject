using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MagazaGidis : MonoBehaviour
{
    [SerializeField] Animator resim_1_animator;
    [SerializeField] Animator resim_2_animator;
    [SerializeField] Animator resim_3_animator;
    [SerializeField] Animator resim_4_animator;
    [SerializeField] Animator resim_5_animator;
    [SerializeField] Animator resim_6_animator;

    [SerializeField]
    bool z1, z2, z3, z4, z5, z6;

    private void Awake()
    {
        //Deðiþkenlerin baþlangýç deðerleri
        z1 = true;
        z2 = false;
        z3 = false;
        z4 = false;
        z5 = false;
        z6 = false;
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
        else if (Input.GetMouseButtonDown(0) && z3 == true)
        {
            resim_3_animator.SetBool("Geçiþ3", true);
            Invoke("Anim3", 0.5f);

            z3 = false;
            z4 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z4 == true)
        {
            resim_4_animator.SetBool("Geçiþ4", true);
            Invoke("Anim4", 0.5f);

            z4 = false;
            z5 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z5 == true)
        {
            resim_5_animator.SetBool("Geçiþ5", true);
            Invoke("Anim5", 0.5f);

            z5 = false;
            z6 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z6 == true)
        {
            resim_6_animator.SetBool("Geçiþ6", true);
            Invoke("Anim6", 0.5f);
            StartCoroutine(SonGeçiþ());

            z6 = false;
            


        }
       



    }
    IEnumerator SonGeçiþ()
    {
        //Sahne geçiþi için gerekli olan delay
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(22);
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
        //2.resim ile 3.resim arasýndaki gerekli olan delay için yazýlmýþ fonk
        resim_4_animator.SetBool("Geçiþ3", true);
    }
    private void Anim4()
    {
        //2.resim ile 3.resim arasýndaki gerekli olan delay için yazýlmýþ fonk
        resim_5_animator.SetBool("Geçiþ4", true);
    }
    private void Anim5()
    {
        //2.resim ile 3.resim arasýndaki gerekli olan delay için yazýlmýþ fonk
        resim_6_animator.SetBool("Geçiþ5", true);
    }
    

}
