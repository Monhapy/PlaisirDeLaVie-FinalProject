using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hayal : MonoBehaviour
{
    public Animator balon1, balon2, balon3, hayal;
    public bool z1, z0;

    private void Start()
    {
        z0= true;
        z1= false;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && z0==true)
        {
            balon1.SetBool("Balon1", true);
            Invoke("Balon2", 1f);
            Invoke("Balon3", 2f);
            Invoke("Hayall", 3f);
            z0 = false;
            z1= true;
        }
        else if (Input.GetMouseButtonDown(0) && z1==true)
        {
            SceneManager.LoadScene(28);
        }
    }
    private void Balon2()
    {
        balon2.SetBool("Balon2", true);
    }
    private void Balon3()
    {
        balon3.SetBool("Balon3", true);
    }
    private void Hayall()
    {
        hayal.SetBool("Hayal", true);
    }
}
