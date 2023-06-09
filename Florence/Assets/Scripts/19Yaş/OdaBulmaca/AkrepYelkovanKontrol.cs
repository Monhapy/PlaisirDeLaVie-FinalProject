using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkrepYelkovanKontrol : MonoBehaviour
{
    public GameObject yelkovan, akrep,saatAçýk,saat;
    void Update()
    {
        
        if (yelkovan != null && yelkovan.activeSelf)
        {
            if (akrep != null && akrep.activeSelf)
            {
                Invoke("SaatAçýlýþ", 1f);
            }
            

        }
    }
    public void SaatAçýlýþ()
    {
        saatAçýk.SetActive(true);
        saat.SetActive(false);
    }
}
