using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneYönetim : MonoBehaviour
{
    // Her resim için animatorlerin çekilmesi
    
    [SerializeField] Animator resim_1_animator;
    [SerializeField] Animator resim_2_animator;
    [SerializeField] Animator resim_3_animator;
    [SerializeField] Animator resim_4_animator;

    // Hangi animasyonun neyden sonra oynayacaðýnýn kontrolü için deðiþkenler
    [SerializeField] bool g1, g2, g3,g4 ;

    public void Awake()
    {
        //Deðiþkenlerin baþlangýç deðerleri
        g1 = true;
        g2 = false;
        g3 = false;
        g4 = false;
    }

    
    public void Update()
    {
        //1.resimin animasyon kodu
        if (Input.GetMouseButtonDown(0) && g1 == true)
        {
            resim_1_animator.SetBool("Geçiþ1",true);
            Invoke("Anim1", 0.5f);
            
            g1 = false;
            g2= true;

        
        }
        //2.resimin animasyon kodu
        else if (Input.GetMouseButtonDown(0) && g2 == true)
        {
            resim_2_animator.SetBool("Geçiþ2", true);
            Invoke("Anim2", 0.5f);
            
            g2 = false;
            g3 = true;


        }
        //3. resimin animasyon kodu 
        else if (Input.GetMouseButtonDown(0) && g3 == true)
        {
            resim_3_animator.SetBool("Geçiþ3", true);
            Invoke("Anim3", 0.5f);
            
            g3 = false;
            g4 = true;


        }
        //Son resimin animasyon kodu ve sahne geçiþi
        else if (Input.GetMouseButtonDown(0) && g4 == true)
        {
            resim_4_animator.SetBool("Geçiþ4", true);
            StartCoroutine(SonGeçiþ());
            
        }
    }
    IEnumerator SonGeçiþ()
    {
        //Sahne geçiþi için gerekli olan delay
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(2);
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
        //3.resim ile 4.resim arasýndaki gerekli olan delay için yazýlmýþ fonk
        resim_4_animator.SetBool("Geçiþ3", true);
    }


}
