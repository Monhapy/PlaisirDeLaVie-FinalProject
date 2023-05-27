using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YediToOnDört : MonoBehaviour
{
    [SerializeField] GameObject yazi;

    private void Start()
    {
        
    }
    void Update()
    {
       

        if (Input.GetMouseButtonDown(0))
        {
            
            
            Invoke("Gidiş", 1.5f);
        }
    }
    void Gidiş()
    {
        SceneManager.LoadScene(12);
    }
    
}
