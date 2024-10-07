using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class LetrasIluminadas : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private TextMeshProUGUI textMeshPro;
    private Color originalColor;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        if (textMeshPro != null )
        {
            originalColor = textMeshPro.color;
        }
    }

    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (textMeshPro != null )
        {
            textMeshPro.color = Color.yellow; //Cambiamos el color del TextMEshPro al color amarillo
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (textMeshPro != null )
        {
            textMeshPro.color = originalColor; //Restaura el color original
        }
    }
}
