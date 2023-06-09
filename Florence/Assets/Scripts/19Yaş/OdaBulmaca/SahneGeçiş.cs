using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGeçiş : MonoBehaviour
{
    public GameObject targetObject, anahtar; // Üstüne bırakılacak obje


    private bool isDragging = false;
    private Vector3 offset;

    private void OnMouseDown()
    {
        offset = gameObject.transform.position - GetMouseWorldPosition();
        isDragging = true;
    }

    private void OnMouseUp()
    {
        if (targetObject != null && isDragging)
        {
            anahtar.SetActive(false);
            targetObject.SetActive(false);
            Invoke("SahneGeçiş1",1f);
        }
        isDragging = false;
    }

    private void Update()
    {
        if (isDragging)
        {
            Vector3 mousePos = GetMouseWorldPosition();
            transform.position = new Vector3(mousePos.x + offset.x, mousePos.y + offset.y, transform.position.z);
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
    private void SahneGeçiş1()
    {
        SceneManager.LoadScene(21);
    }
}
