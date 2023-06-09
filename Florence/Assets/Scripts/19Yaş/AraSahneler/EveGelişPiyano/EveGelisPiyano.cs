using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EveGelisPiyano : MonoBehaviour
{
    [SerializeField] private Animator resim2, camAnims;
    public bool p1, p2;
    
    private void Start()
    {
        p1 = true;
        p2 = false;
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && p1 == true)
        {
            resim2.SetBool("Geliþ3", true);
            p1 = false;
            p2 = true;
        }
        
        else if (Input.GetMouseButtonDown(0) && p2== true)
        {
            camAnims.SetBool("CamMove", true);

        }
    }
}
