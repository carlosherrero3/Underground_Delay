using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesplazarBotones : MonoBehaviour
{
    public float desplazamiento = 50f; //Controlador para desplazar el bot�n.
    private Vector3 posicionInicial;
    private RectTransform rectTransform;

    private void Start() //Guardamos la posici�n inicial del bot�n.
    {
        rectTransform = GetComponent<RectTransform>();
        posicionInicial = rectTransform.anchoredPosition;
    }

    void Update()
    {
        
    }

    public void OnMouseEnter() //Cuando el rat�n entra.
    {
        rectTransform.anchoredPosition = new Vector3(posicionInicial.x + desplazamiento, posicionInicial.y, 0); //Desplazamos el bot�n hac�a la derecha.
    }

    public void OnMouseExit() //Cuando el rat�n sale.
    {
        rectTransform.anchoredPosition = posicionInicial;
    }
}
