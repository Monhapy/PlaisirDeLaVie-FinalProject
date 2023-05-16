using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Salata : MonoBehaviour
{
    public GameObject dolusalata, boþsalata, yarýdolusalata,kruvasan;
    public GameObject background1,background2, background3;
    public Animator cameraAnim;
    public void DoluSalata()
    {
        background1.SetActive(false);
        dolusalata.SetActive(false);
        yarýdolusalata.SetActive(true);
        background2.SetActive(true);
    }
    public void YarýSalata()
    {
        background2.SetActive(false);
        background3.SetActive(true);
        yarýdolusalata.SetActive(false);
        boþsalata.SetActive(true);
    }
    public void BoþSalata()
    {

        boþsalata.SetActive(false);
        kruvasan.SetActive(false);
        StartCoroutine(Delay());
        cameraAnim.SetBool("Kamera", true);
        StartCoroutine(SahneGeçiþ());
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1.5f);
    }
    IEnumerator SahneGeçiþ()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(5);

    }
}
