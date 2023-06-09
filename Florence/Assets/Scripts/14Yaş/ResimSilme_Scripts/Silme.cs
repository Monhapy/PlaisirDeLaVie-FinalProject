using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Silme : MonoBehaviour
{
    [SerializeField] GameObject mask;
    [SerializeField] GameObject buton,background;

    public Animator backgroundAnim, backgroundAnim2;

    [SerializeField] bool pressed;
    [SerializeField] bool z1;

    public GameObject cam;
    private float camPositionY;

    private void Awake()
    {
        z1 = true;
    }

    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        camPositionY=cam.transform.position.y;

        if (Input.GetMouseButtonDown(0) && z1 == true )
        {
           buton.SetActive(true);
              
        }

        if (Input.GetMouseButtonDown(0))
        {
            pressed = true;
            z1 = false;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            pressed = false;
        }
        else if (pressed == true)
        {
            GameObject ob = Instantiate(mask, pos, Quaternion.identity);
            ob.transform.parent = GameObject.Find("scratch").transform;
            
            
        }

        





    }

    private void Start()
    {
        Invoke("BackgroundDelay", 2.5f);
    }
    public void LevelChange()
    {
        backgroundAnim.SetBool("Geçiþ1", true);
        backgroundAnim2.SetBool("Geçiþ2", true);
        buton.SetActive(false);
        Invoke("LevelDelay", 3f);
    }
    private void BackgroundDelay()
    {
        background.SetActive(true);
    }
    private void LevelDelay()
    {
        SceneManager.LoadScene(17);
    }




}
