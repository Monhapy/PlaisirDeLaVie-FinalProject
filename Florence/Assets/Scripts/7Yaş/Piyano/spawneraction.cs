using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawneraction : MonoBehaviour
{
    public float width = 10f;
    public float height = 5f;
    public GameObject painotile;
    public float delay = 0.5f;
  
    void Start()
    {
        spwanuntill();
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));
    }
   
    void Update()
    {
        if (checkforempty())
        {
            spwanuntill();
        }
    }
    void spwanuntill()
    {
        Transform position = freeposition();
        if (position)
        {
            GameObject piano = Instantiate(painotile,position.transform.position, Quaternion.identity);
            piano.transform.parent = position;

        }

        if(freeposition())
        {
            Invoke("spwanuntill",delay);
        }

    }
    void spwaner()
    {
        foreach (Transform child in transform)
        {
            GameObject piano = Instantiate(painotile, child.position, Quaternion.identity);
            piano.transform.parent = child;
        }
    }
    bool checkforempty()
    {
        foreach (Transform child in transform)
        {
            if (child.childCount > 0)
            {
                return false;
            }

        }
        return true;
    }

    Transform freeposition()
    {
        foreach (Transform child in transform)
        {
            if (child.childCount==0)
            {
                return child;
            }

        }
        return null;
    }
}
