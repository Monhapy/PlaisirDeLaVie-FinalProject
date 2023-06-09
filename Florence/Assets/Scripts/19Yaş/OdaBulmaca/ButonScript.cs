using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButonScript : MonoBehaviour
{
    public GameObject kasaCanvas,dolap,açýkdolap,kýyafett,küçükKasa,daðýnýkKýyafet;
    public GameObject kitap1, kitap2, kitap3, kitap4,daðýnýk1,daðýnýk2,daðýnýk3,daðýnýk4;
    public GameObject resim, düþmüþResim,anahtar1;
    public GameObject akrep,anahtar2;

    public void KasaGidiþ()
    {
        kasaCanvas.SetActive(false);
        
    }
    public void KasaGeliþ()
    {
        kasaCanvas.SetActive(true);
    }
    
    public void DolapKapak()
    {
        dolap.SetActive(false);
        açýkdolap.SetActive(true);
        kýyafett.SetActive(true);
        daðýnýkKýyafet.SetActive(false);
    }
    public void Kýyafet()
    {
        kýyafett.SetActive(false);
        küçükKasa.SetActive(true);
        daðýnýkKýyafet.SetActive(true);
    }
    public void Kitap1()
    {
        kitap1.SetActive(false);
        daðýnýk1.SetActive(true) ;
    }
    public void Kitap2()
    {
        kitap2.SetActive(false);
        daðýnýk2.SetActive(true);
    }
    public void Kitap3()
    {
        kitap3.SetActive(false);
        daðýnýk3.SetActive(true);
    }
    public void Kitap4()
    {
        kitap4.SetActive(false);
        daðýnýk4.SetActive(true);
    }
    public void Resim()
    {
        resim.SetActive(false); 
        düþmüþResim.SetActive(true);
    }
    public void DüþmüþResim()
    {
        düþmüþResim.SetActive(false);
        anahtar1.SetActive(true);
    }
    public void Çekmece()
    {
        akrep.SetActive(true);
    }
    public void Saat()
    {
        anahtar2.SetActive(true) ;
    }
}
