using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YediToOnDört : MonoBehaviour
{
    [SerializeField] Animator yazi;

    private void Start()
    {
        
    }
    void Update()
    {
       

        if (Input.GetMouseButtonDown(0))
        {
            yazi.SetBool("OnDört", true);
            
            Invoke("Gidiş", 3f);
        }
    }
    void Gidiş()
    {
        SceneManager.LoadScene(12);
    }
    
}
