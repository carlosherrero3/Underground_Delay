using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesplazarBotones : MonoBehaviour
{
    public float desplazamiento = 50f; //Controlador para desplazar el botón.
    private Vector3 posicionInicial;
    private RectTransform rectTransform;

    private void Start() //Guardamos la posición inicial del botón.
    {
        rectTransform = GetComponent<RectTransform>();
        posicionInicial = rectTransform.anchoredPosition;
    }

    void Update()
    {
        
    }

    public void OnMouseEnter() //Cuando el ratón entra.
    {
        rectTransform.anchoredPosition = new Vector3(posicionInicial.x + desplazamiento, posicionInicial.y, 0); //Desplazamos el botón hacía la derecha.
    }

    public void OnMouseExit() //Cuando el ratón sale.
    {
        rectTransform.anchoredPosition = posicionInicial;
    }
}
