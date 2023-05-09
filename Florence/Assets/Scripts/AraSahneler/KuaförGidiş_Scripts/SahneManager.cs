using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneManager : MonoBehaviour
{
    public Animator kuaför,kuaför2;
    public bool z1, z2;


    private void Awake()
    {
        z1 = true;
        z2 = false;

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && z1== true)
        {
            kuaför.SetBool("Kayma", true);
            z1 = false;
            z2 = true;

        }
        else if(Input.GetMouseButtonDown(0) && z2 == true)
        {
            kuaför2.SetBool("Kayma2", true);
            z2 = false;
            StartCoroutine(SahneDelay());
        }
    }
    IEnumerator SahneDelay()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(6);
    }
}
