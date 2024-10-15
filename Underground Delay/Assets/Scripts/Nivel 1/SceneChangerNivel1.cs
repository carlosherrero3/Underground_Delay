using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNivel1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Menú Principal"); //Aquí hay que cambiar lo que hay entre las comillas por la escena deseada
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
