using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeControl : MonoBehaviour
{
    public Taþý taþý1, taþý2, taþý3, taþý4, taþý5, taþý6 = new Taþý();
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
                                Invoke("SahneGeçiþiii", 1f);
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
}
