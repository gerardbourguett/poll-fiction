using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Generic desktop window: knows how to open, close and bring itself to front.
/// In UGUI the last sibling is drawn on top, so SetAsLastSibling is the whole z-order system.
/// </summary>
public class Ventana : MonoBehaviour, IPointerDownHandler
{
    public void Abrir()
    {
        gameObject.SetActive(true);
        transform.SetAsLastSibling(); // bring to front
    }

    public void Cerrar() => gameObject.SetActive(false);

    public void OnPointerDown(PointerEventData e) => transform.SetAsLastSibling();
}
