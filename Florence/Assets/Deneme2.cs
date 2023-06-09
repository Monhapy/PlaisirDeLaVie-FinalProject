using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deneme2 : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(24);
        }
    }
}
