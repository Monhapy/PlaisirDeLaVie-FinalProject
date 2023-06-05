using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeControl : MonoBehaviour
{
    public Taþý taþý1, taþý2, taþý3, taþý4, taþý5, taþý6 ;
    public Animator camAnim,animÇ,anim1,anim2,anim3,anim4,anim5,anim6;
    void Update()
    {
        if (taþý1.denemesayi2 == 1)
        {
            if (taþý2.denemesayi2 == 1)
            {
                if (taþý3.denemesayi2 == 1)
                {
                    if (taþý4.denemesayi2 == 1)
                    {
                        if (taþý5.denemesayi2 == 1)
                        {
                            if (taþý6.denemesayi2 == 1)
                            {
                                camAnim.SetBool("Zoom", true);
                                Invoke("AnimGecikme", 3f);
                                Invoke("SahneGeçiþiii", 6f);
                            }
                        }
                    }
                }
            }
        }
    }
    private void SahneGeçiþiii()
    {
        SceneManager.LoadScene(13);
    }
    private void AnimGecikme()
    {
        animÇ.SetBool("GidiþÇ", true);
        anim1.SetBool("Gidiþ1", true);
        anim2.SetBool("Gidiþ2", true);
        anim3.SetBool("Gidiþ3", true);
        anim4.SetBool("Gidiþ4", true);
        anim5.SetBool("Gidiþ5", true);
        anim6.SetBool("Gidiþ6", true);
    }
}
