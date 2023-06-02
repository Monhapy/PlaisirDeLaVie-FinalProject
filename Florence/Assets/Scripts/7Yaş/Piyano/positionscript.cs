using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionscript : MonoBehaviour
{
    public float width = 10f;
    public float height = 5f;
   
    void Start()
    {
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));
    }
    
    void Update()
    {
    }
}
