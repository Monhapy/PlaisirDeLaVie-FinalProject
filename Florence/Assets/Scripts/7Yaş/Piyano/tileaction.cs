using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileaction : MonoBehaviour
{
    public SpriteRenderer color;
    public int scorevalue = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            color.color = new Color(234f/255f,214/255f,177/255f);
               
            FindObjectOfType<score>().Scoreupdate(scorevalue);
        }
    }
 }
