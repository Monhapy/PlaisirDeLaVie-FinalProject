using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diş : MonoBehaviour
{
    //Erişip değişiklik yapmak istediğimiz objelerin değişkenleri
    public GameObject diş;
    public GameObject buton;

    //Renk değişkeni
    private Color dişRengi;
    private bool butonEtkinleştirildi = false;
    private void OnTriggerEnter2D(Collider2D fırça)
    {
        //Fırçanın dişe temasını anlaması
        if (fırça.CompareTag("Diş") && !butonEtkinleştirildi)
        {
            //Temas halinde renkteki B de değişiklik yapması
            dişRengi = diş.GetComponent<SpriteRenderer>().color;
            dişRengi.b += 0.05f;
            diş.GetComponent<SpriteRenderer>().color = dişRengi;

            //Dişler beyazlayınca butonun aktif olması
            if (dişRengi.b >= 0.98f)
            {
                buton.SetActive(true);
                butonEtkinleştirildi = true;
            }

        }
        
    }
    

}