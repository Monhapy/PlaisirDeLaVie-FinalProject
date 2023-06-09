using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Camera cam;
    public List<GameObject> objectsToExclude = new List<GameObject>();
    private Vector3 dragOrigin;
    private bool isObjectClicked = false;

    private float minY = 0f;
    private float maxY = 8f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && objectsToExclude.Contains(hit.collider.gameObject))
            {
                isObjectClicked = true;
                return;
            }
            else
            {
                isObjectClicked = false;
                dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);
            }
        }

        if (Input.GetMouseButton(0) && !isObjectClicked)
        {
            Vector3 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
            float differenceY = dragOrigin.y - newPosition.y;

            float newCamY = Mathf.Clamp(cam.transform.position.y + differenceY, minY, maxY);
            cam.transform.position = new Vector3(cam.transform.position.x, newCamY, cam.transform.position.z);
        }
    }
}
