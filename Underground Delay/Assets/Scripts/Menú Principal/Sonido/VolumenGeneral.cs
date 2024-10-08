using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumenGeneral : MonoBehaviour
{
    public Slider slider;
    public float sliderValue; //Variables.
    public Image imagenMute;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f); //Con Get se invoca la varible audio y después de la coma se añade el valor o variable.
        AudioListener.volume = slider.value;
        RevisarMute();
    }

    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = sliderValue;
        RevisarMute();
    }
    void Update()
    {
        
    }

    public void RevisarMute() //Con esta función se activa o se desactiva la imagen de mute
    {
        if (sliderValue == 0f)
        {
            imagenMute.enabled = true;
        }
        else
        {
            imagenMute.enabled= false;
        }
    }
}
