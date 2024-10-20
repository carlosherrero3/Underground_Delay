using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts; //Referencia para las vidas.
    public int life = 3; //La vida que va a tener el personaje.

    void Start()
    {
        UpdateHearts();
    }

    void Update()
    {
        
    }

    public void TakeDamage(int damage) //Metodo que reduce la vida.
    {
        life -= damage;
        if (life < 0) life = 0;

        UpdateHearts(); //Actualizamos corazones.

        if (life <= 0)
        {
            Die(); //0 corazones y morimos.
        }
    }

    void UpdateHearts() //Método para actualizar la visualización de los corazones.
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < life)
            {
                hearts[i].SetActive(true);
            }
            else
            {
                hearts[i].SetActive(false);
            }
        }
    }

    void Die() //Función para detectar cuando el personaje ha muerto.
    {
        Time.timeScale = 0f;
        Debug.Log("El personaje ha muerto");
    }
}
