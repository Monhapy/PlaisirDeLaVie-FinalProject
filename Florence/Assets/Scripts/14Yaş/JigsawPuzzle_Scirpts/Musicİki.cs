using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Musicİki : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

    }
    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "14to19Yaş")
        {
            Destroy(gameObject);
        }
    }
}
