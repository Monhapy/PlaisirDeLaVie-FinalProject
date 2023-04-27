using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SahneYönetim_2 : MonoBehaviour
{
    //Fırça ve dişlerin geliş animasyonu için animator değişkenleri
    public Animator dişfırça_animator;
    public Animator dişler_animator;
    public Animator background_animator;
    

    

    void Update()
    {
        //Mouse input ile objelerin animasyonunun oynaması
        if (Input.GetMouseButtonDown(0))
        {
            dişfırça_animator.SetBool("Fırça", true);
            dişler_animator.SetBool("Damak", true);
            StartCoroutine(BeklemeFonk());
            
        }
        
        
    }
    IEnumerator BeklemeFonk()
    {
        //Objelerin animasyon oynadıktan sonra animatorun kapatılması
        yield return new WaitForSeconds(1.5f);
        dişfırça_animator.enabled = false;
    }
    public void SahneGeçiş()
    {
        //Butona tıklandığında diğer sahneye geçiş
        SceneManager.LoadScene(2);
    }
}
