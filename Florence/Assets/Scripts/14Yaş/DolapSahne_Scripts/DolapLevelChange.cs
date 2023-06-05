using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DolapLevelChange : MonoBehaviour
{
    public Taþý taþý1, taþý2, taþý3;
    public Animator camAnim, kitapAnim,backgroundAnim;
    public GameObject kitap1,kitap2,kitap3;
    void Update()
    {
        if (taþý1.denemesayi2 == 1)
        {
            if (taþý2.denemesayi2 == 1)
            {
                if (taþý3.denemesayi2 == 1)
                {
                    kitapAnim.SetBool("KitaplarGidiþ", true);
                    backgroundAnim.SetBool("Gidiþ", true);
                    Invoke("SahneGeçiþiii", 3f);
                    
                }
            }
        }
    }
    private void SahneGeçiþiii()
    {
        SceneManager.LoadScene(15);
    }
    private void Start()
    {
        Invoke("KitapGecikme", 2f);
    }
    private void KitapGecikme()
    {
        kitapAnim.SetBool("KitapGeliþ", true);
        kitap1.SetActive(true); 
        kitap2.SetActive(true);
        kitap3.SetActive(true);
    }
}
