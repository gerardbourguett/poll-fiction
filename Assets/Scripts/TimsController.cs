using UnityEngine;
using System.Collections;
using TMPro;

public class TimsController : MonoBehaviour
{
    public Transform contenedorMensajes;   // Scroll/Viewport/Content
    public GameObject prefabBurbuja;

    public void Reproducir(Conversacion c) => StartCoroutine(Correr(c));

    IEnumerator Correr(Conversacion c)
    {
        foreach (var m in c.mensajes)
        {
            yield return new WaitForSeconds(m.esperaSegundos);
            var b = Instantiate(prefabBurbuja, contenedorMensajes);
            b.GetComponentInChildren<TMP_Text>().text = $"<b>{m.autor}:</b> {m.texto}";
        }
    }
}
