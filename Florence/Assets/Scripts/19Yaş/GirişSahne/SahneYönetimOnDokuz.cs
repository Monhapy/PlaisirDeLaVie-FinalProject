using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneYönetimOnDokuz : MonoBehaviour
{
    // Her resim için animatorlerin çekilmesi

    [SerializeField] Animator resim_1_animator;
    [SerializeField] Animator resim_2_animator;
    [SerializeField] Animator resim_3_animator;
    [SerializeField] Animator resim_4_animator;
    [SerializeField] Animator resim_5_animator;
    [SerializeField] Animator resim_6_animator;
    [SerializeField] Animator resim_7_animator;
    [SerializeField] Animator resim_8_animator;
    [SerializeField] Animator resim_9_animator;
    [SerializeField] Animator resim_10_animator;



    // Hangi animasyonun neyden sonra oynayacağının kontrolü için değişkenler
    [SerializeField] bool z1, z2, z3,z4,z5,z6,z7,z8,z9,z10;

    private void Awake()
    {
        //Değişkenlerin başlangıç değerleri
        z1 = true;
        z2 = false;
        z3 = false;
        z4 = false;
        z5 = false;
        z6 = false; 
        z7 = false; 
        z8 = false;
        z9 = false;
        z10 = false;

    }
    private void Update()
    {


        //1.resimin animasyon kodu
        if (Input.GetMouseButtonDown(0) && z1 == true)
        {
            resim_1_animator.SetBool("Geçiş1", true);
            Invoke("Anim1", 0.5f);

            z1 = false;
            z2 = true;


        }
        //2.resimin animasyon kodu
        else if (Input.GetMouseButtonDown(0) && z2 == true)
        {
            resim_2_animator.SetBool("Geçiş2", true);
            Invoke("Anim2", 0.5f);

            z2 = false;
            z3 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z3 == true)
        {
            resim_3_animator.SetBool("Geçiş3", true);
            Invoke("Anim3", 0.5f);

            z3 = false;
            z4 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z4 == true)
        {
            resim_4_animator.SetBool("Geçiş4", true);
            Invoke("Anim4", 0.5f);

            z4 = false;
            z5 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z5 == true)
        {
            resim_5_animator.SetBool("Geçiş5", true);
            Invoke("Anim5", 0.5f);

            z5 = false;
            z6 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z6 == true)
        {
            resim_6_animator.SetBool("Geçiş6", true);
            Invoke("Anim6", 0.5f);

            z6 = false;
            z7 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z7 == true)
        {
            resim_7_animator.SetBool("Geçiş7", true);
            Invoke("Anim7", 0.5f);

            z7 = false;
            z8 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z8 == true)
        {
            resim_8_animator.SetBool("Geçiş8", true);
            Invoke("Anim8", 0.5f);

            z8 = false;
            z9 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z9 == true)
        {
            resim_9_animator.SetBool("Geçiş9", true);
            Invoke("Anim9", 0.5f);

            z9 = false;
            z10= true;


        }

        //3. resimin animasyon kodu 
        else if (Input.GetMouseButtonDown(0) && z10 == true)
        {
            resim_10_animator.SetBool("Geçiş10", true);
            StartCoroutine(SonGeçiş());

            z10 = false;



        }



    }
    IEnumerator SonGeçiş()
    {
        //Sahne geçişi için gerekli olan delay
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(19);
    }
    private void Anim1()
    {
        //1.resim ile 2.resim arasındaki gerekli olan delay için yazılmış fonk
        resim_2_animator.SetBool("Geçiş1", true);
    }
    private void Anim2()
    {
        //2.resim ile 3.resim arasındaki gerekli olan delay için yazılmış fonk
        resim_3_animator.SetBool("Geçiş2", true);
    }
    private void Anim3()
    {
        //2.resim ile 3.resim arasındaki gerekli olan delay için yazılmış fonk
        resim_4_animator.SetBool("Geçiş3", true);
    }
    private void Anim4()
    {
        //2.resim ile 3.resim arasındaki gerekli olan delay için yazılmış fonk
        resim_5_animator.SetBool("Geçiş4", true);
    }
    private void Anim5()
    {
        //2.resim ile 3.resim arasındaki gerekli olan delay için yazılmış fonk
        resim_6_animator.SetBool("Geçiş5", true);
    }
    private void Anim6()
    {
        //2.resim ile 3.resim arasındaki gerekli olan delay için yazılmış fonk
        resim_7_animator.SetBool("Geçiş6", true);
    }
    private void Anim7()
    {
        //2.resim ile 3.resim arasındaki gerekli olan delay için yazılmış fonk
        resim_8_animator.SetBool("Geçiş7", true);
    }
    private void Anim8()
    {
        //2.resim ile 3.resim arasındaki gerekli olan delay için yazılmış fonk
        resim_9_animator.SetBool("Geçiş8", true);
    }
    private void Anim9()
    {
        //2.resim ile 3.resim arasındaki gerekli olan delay için yazılmış fonk
        resim_10_animator.SetBool("Geçiş9", true);
    }
}
