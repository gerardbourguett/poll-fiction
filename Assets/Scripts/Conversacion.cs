using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Poll Fiction/Conversacion")]
public class Conversacion : ScriptableObject
{
    public List<Mensaje> mensajes;
}

[System.Serializable]
public class Mensaje
{
    public string autor;
    [TextArea] public string texto;
    public float esperaSegundos = 1.5f;
    public string[] respuestas;   // vacío = no espera respuesta
    public string disparador;     // vacío = no dispara nada
}
