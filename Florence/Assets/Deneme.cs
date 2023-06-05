using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deneme : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(1);
        }
    }
}
