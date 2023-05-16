using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneYönetim : MonoBehaviour
{
    // Her resim için animatorlerin çekilmesi
    public Animator resim_1_animator;
    public Animator resim_2_animator;
    public Animator resim_3_animator;
    public Animator resim_4_animator;

    // Hangi animasyonun neyden sonra oynayacaðýnýn kontrolü için deðiþkenler
    public bool g1, g2, g3,g4 ;

    public void Awake()
    {
        //Deðiþkenlerin baþlangýç deðerleri
        g1 = true;
        g2 = false;
        g3 = false;
        g4 = false;
    }

    //Son resmin animasyonunun oynayýp sahne geçiþi olmasý için gerekli olan delay fonksiyonu
    IEnumerator SonGeçiþ()
    {
        yield return new WaitForSeconds(3f);
        
        SceneManager.LoadScene(2);
    }
    public void Update()
    {
        //1.resimin animasyon kodu
        if (Input.GetMouseButtonDown(0) && g1 == true)
        {
            resim_1_animator.SetBool("Geçiþ1",true);
            g1= false;
            g2= true;

        
        }
        //2.resimin animasyon kodu
        else if (Input.GetMouseButtonDown(0) && g2 == true)
        {
            resim_2_animator.SetBool("Geçiþ2", true);
            g2 = false;
            g3 = true;


        }
        //3. resimin animasyon kodu 
        else if (Input.GetMouseButtonDown(0) && g3 == true)
        {
            resim_3_animator.SetBool("Geçiþ3", true);
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
    
}
