using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deneme : MonoBehaviour
{
    public Animator arkaplan, yazý,cam;
    private void Start()
    {
        Invoke("Yazý", 3f);
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            yazý.SetBool("Gidiþ", true);
            cam.SetBool("Cam", true);
            Invoke("Beyaz", 2.5f);
            Invoke("Sahne", 5f);

        }
    }
    private void Yazý()
    {
        yazý.SetBool("Yazý", true);
    }
    private void Beyaz()
    {
        arkaplan.SetBool("Beyaz", true);
        
    }
    private void Sahne()
    {
        SceneManager.LoadScene(1);
    }
}
