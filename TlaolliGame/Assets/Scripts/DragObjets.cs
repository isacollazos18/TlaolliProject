using UnityEngine;

public class DragObjets : MonoBehaviour
{
    private Vector3 offset;
    private Camera mainCamera;
    private Vector3 startPosition;

    void Start()
    {
        mainCamera = Camera.main;
        startPosition = transform.position; // Guarda la posición inicial
    }

    void OnMouseDown()
    {
        offset = transform.position - GetMouseWorldPosition();
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() + offset;
    }

    void OnMouseUp()
    {
        if (!IsInsideDropZone())
        {
            transform.position = startPosition; // Si no está en la zona, regresa a su lugar
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private bool IsInsideDropZone()
    {
        // Aquí puedes agregar lógica extra si lo necesitas
        return true; // Devuelve true si quieres permitir que se quede en cualquier lado
    }
}
