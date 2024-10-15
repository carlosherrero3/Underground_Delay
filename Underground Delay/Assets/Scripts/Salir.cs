using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Salir : MonoBehaviour
{
    public void Salirse() 
    {
        Application.Quit(); //Para salir del juego
        Debug.Log("Ha salido del juego ");
    }
}
