using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButonKontrols : MonoBehaviour
{
    public Animator kruvasan_animator;
    public GameObject background,background2;
    

    public void Kruvasan()
    {

        kruvasan_animator.SetBool("kruvasan", true);
        background.SetActive(false);
        
    }

   

    public void SetKruvasanInactive()
    {
        kruvasan_animator.SetBool("kruvasan", false);
    }
}
