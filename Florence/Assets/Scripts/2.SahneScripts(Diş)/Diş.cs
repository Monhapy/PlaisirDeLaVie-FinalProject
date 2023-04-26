using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diş : MonoBehaviour
{
    public GameObject diş;
    private Color dişRengi;

    private void OnTriggerEnter2D(Collider2D fırça)
    {
        if (fırça.CompareTag("Diş"))
        {
            dişRengi = diş.GetComponent<SpriteRenderer>().color;
            dişRengi.b += 0.05f;
            diş.GetComponent<SpriteRenderer>().color = dişRengi;
        }
        
    }
}