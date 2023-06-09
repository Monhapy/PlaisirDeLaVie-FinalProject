using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KasaKod : MonoBehaviour
{
    public RectTransform kasaKod1RectTransform, kasaKod2RectTransform, kasaKod3RectTransform, kasaKod4RectTransform;
    public float kasaKodKontrol1_y,kasaKodKontrol2_y, kasaKodKontrol3_y, kasaKodKontrol4_y;
    public GameObject buton,yelkovan;
    public Color color;
   
    void Update()
    {
        color.a = 1f;
        KasaKontrol();
    }
    public void KasaKontrol()
    {
        kasaKodKontrol1_y = kasaKod1RectTransform.anchoredPosition.y;
        kasaKodKontrol2_y = kasaKod2RectTransform.anchoredPosition.y;
        kasaKodKontrol3_y = kasaKod3RectTransform.anchoredPosition.y;
        kasaKodKontrol4_y = kasaKod4RectTransform.anchoredPosition.y;

        if (kasaKodKontrol1_y >= 219f && kasaKodKontrol1_y <= 245f)
        {
            

            if (kasaKodKontrol2_y >= 2f && kasaKodKontrol2_y <= 30f)
            {
                

                if (kasaKodKontrol3_y >= -221f && kasaKodKontrol3_y <= -189f)
                {
                    

                    if (kasaKodKontrol4_y >= -433f && kasaKodKontrol4_y <= -401f)
                    {
                        
                        buton.GetComponent<Image>().color=Color.green;
                        
                        yelkovan.GetComponent<SpriteRenderer>().color = color;
                    }
                }
            }
        }
    }

}
