using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamAnimAndDelay : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] Animator backgroundAnim;
     public HareketKontrol hareketkontrol1,hareketkontrol2, hareketkontrol3, hareketkontrol4, hareketkontrol5 ;
     
     
     

    private void Start()
    {
        
        Invoke("CanvasActive", 2f);

    }
    private void CanvasActive()
    {
        canvas.SetActive(true);
    }
    private void SahneGeçiþii()
    {
        SceneManager.LoadScene(11);
    }
    private void Update()
    {
       if(hareketkontrol1.denemeSayi == 1)
       {
            if (hareketkontrol2.denemeSayi == 1)
            {
                if (hareketkontrol3.denemeSayi == 1)
                {
                    if (hareketkontrol4.denemeSayi == 1)
                    {
                        if (hareketkontrol5.denemeSayi == 1)
                        {
                            canvas.SetActive(false);
                            backgroundAnim.SetBool("Kararma", true);
                            Invoke("SahneGeçiþii", 3f);
                        }
                    }
                }
            }
        }
        
    }
}
