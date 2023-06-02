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
            color.color = Color.yellow;
               
            FindObjectOfType<score>().Scoreupdate(scorevalue);
        }
    }
 }
