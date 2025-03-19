using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Maiz"))
        {
            Debug.Log("Maíz colocado correctamente en la zona.");
            other.transform.position = transform.position; // Ajusta la posición del Maíz
        }
    }
}
