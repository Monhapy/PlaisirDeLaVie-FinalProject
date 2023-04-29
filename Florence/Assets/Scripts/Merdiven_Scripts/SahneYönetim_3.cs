using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneYönetim_3 : MonoBehaviour
{
    // Her resim için animatorlerin çekilmesi
    public Animator resim_1animator;
    public Animator resim_2animator;
    public Animator resim_3animator;

    // Hangi animasyonun neyden sonra oynayacağının kontrolü için değişkenler
    public bool f1, f2, f3;
    void Awake()
    {
        //Değişkenlerin başlangıç değerleri
        f1 = true;
        f2 = false;
        f3 = false;
        
    }
    IEnumerator SonGeçme()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(4);
    }

    // Update is called once per frame
    void Update()
    {

        //1.resimin animasyon kodu
        if (Input.GetMouseButtonDown(0) && f1 == true)
        {
            resim_1animator.SetBool("Geçme1", true);
            f1 = false;
            f2 = true;


        }
        //2.resimin animasyon kodu
        else if (Input.GetMouseButtonDown(0) && f2 == true)
        {
            resim_2animator.SetBool("Geçme2", true);
           
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
}
