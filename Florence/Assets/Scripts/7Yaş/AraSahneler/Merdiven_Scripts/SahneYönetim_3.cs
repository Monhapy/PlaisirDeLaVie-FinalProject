using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneYönetim_3 : MonoBehaviour
{
    // Her resim için animatorlerin çekilmesi
    
    [SerializeField] Animator resim_1animator;
    [SerializeField] Animator resim_2animator;
    [SerializeField] Animator resim_3animator;

    // Hangi animasyonun neyden sonra oynayacağının kontrolü için değişkenler
    [SerializeField] bool f1, f2, f3;
    void Awake()
    {
        //Değişkenlerin başlangıç değerleri
        f1 = true;
        f2 = false;
        f3 = false;
        
    }
    IEnumerator SonGeçme()
    {
        //Sahne geçişi için delay
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(4);
    }

    
    void Update()
    {

        //1.resimin animasyon kodu
        if (Input.GetMouseButtonDown(0) && f1 == true)
        {
            resim_1animator.SetBool("Geçme1", true);
            Invoke("Anim1",0f);
            f1 = false;
            f2 = true;


        }
        //2.resimin animasyon kodu
        else if (Input.GetMouseButtonDown(0) && f2 == true)
        {
            resim_2animator.SetBool("Geçme2", true);
            Invoke("Anim2", 0f);
            f2 = false;
            f3 = true;


        }
        //Son resimin animasyon kodu ve sahne geçişi
        else if (Input.GetMouseButtonDown(0) && f3 == true)
        {
            resim_3animator.SetBool("Geçme3", true);
            StartCoroutine(SonGeçme());

        }
    }
    
    private void Anim1()
    {
        //1.resim ile 2.resim arasındaki gerekli olan delay için yazılmış fonk
        resim_2animator.SetBool("Geçme1", true);
    }
    private void Anim2()
    {
        //2.resim ile 3.resim arasındaki gerekli olan delay için yazılmış fonk
        resim_3animator.SetBool("Geçme2", true);
    }
}
