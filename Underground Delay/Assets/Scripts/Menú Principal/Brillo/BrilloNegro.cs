using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrilloNegro : MonoBehaviour
{
    public Slider slider;
    public Image imagenNegra;
    public float brilloSlideValue;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("brilloPantalla", 0.1f);
        imagenNegra.color = new Color(imagenNegra.color.r, imagenNegra.color.g, imagenNegra.color.b, slider.value);
    }

    void Update()
    {
        
    }

    public void changeSlider(float valor)
    {
        brilloSlideValue = valor;
        PlayerPrefs.SetFloat("brilloPantalla", brilloSlideValue);
        imagenNegra.color = new Color(imagenNegra.color.r, imagenNegra.color.g, imagenNegra.color.b, slider.value);
    }

}
