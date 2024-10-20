using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrilloBlanco : MonoBehaviour
{
    public Slider slider;
    public Image imagenBlanca;
    public float brilloSlideValue;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("brilloPantalla", 0.1f);
        imagenBlanca.color = new Color(imagenBlanca.color.r, imagenBlanca.color.g, imagenBlanca.color.b, slider.value);
    }

    void Update()
    {

    }

    public void changeSlider(float valor)
    {
        brilloSlideValue = valor;
        PlayerPrefs.SetFloat("brilloPantalla", brilloSlideValue);
        imagenBlanca.color = new Color(imagenBlanca.color.r, imagenBlanca.color.g, imagenBlanca.color.b, slider.value);
    }

}
