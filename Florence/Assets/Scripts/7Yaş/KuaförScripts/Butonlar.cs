using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butonlar : MonoBehaviour
{
    public Animator saç1_animator, cam_animator;
    public bool cam;
    
    public void Saç1()
    {
        saç1_animator.SetBool("Alarm", true);
    }
    public void Saç1Deactive()
    {
       saç1_animator.SetBool("Alarm", false);
    }
    public void Saç2()
    {
        cam_animator.SetBool("Cam", true);
        cam = true;
        StartCoroutine(DelayScene());
    }
    IEnumerator DelayScene() 
    {
        yield return new WaitForSeconds(1.5f);
    }
}
