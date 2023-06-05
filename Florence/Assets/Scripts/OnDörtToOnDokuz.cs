using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnDörtToOnDokuz : MonoBehaviour
{
    public Animator yaziAnim;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            yaziAnim.SetBool("OndörtToOndokuz",true);
            Invoke("Gidiş", 3f);
        }
    }
    void Gidiş()
    {
        SceneManager.LoadScene(18);
    }
}

