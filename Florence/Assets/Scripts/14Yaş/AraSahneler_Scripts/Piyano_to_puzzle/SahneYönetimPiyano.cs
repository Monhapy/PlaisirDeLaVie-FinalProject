using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneYönetimPiyano : MonoBehaviour
{
    // Her resim için animatorlerin çekilmesi

    [SerializeField] Animator resim_1_animator;
    [SerializeField] Animator resim_2_animator;
    [SerializeField] Animator resim_3_animator;


    // Hangi animasyonun neyden sonra oynayacağının kontrolü için değişkenler
    [SerializeField] bool z1, z2, z3;

    private void Awake()
    {
        //Değişkenlerin başlangıç değerleri
        z1 = true;
        z2 = false;
        z3 = false;
            
        
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
            //3. resimin animasyon kodu 
            else if (Input.GetMouseButtonDown(0) && z3 == true)
            {
                resim_3_animator.SetBool("Geçiş3", true);
                StartCoroutine(SonGeçiş());

                z3 = false;
                


            }
           
        

    }
    IEnumerator SonGeçiş()
    {
        //Sahne geçişi için gerekli olan delay
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(14);
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
    
}
