using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReanudarJuego : MonoBehaviour
{
    public GameObject Men�;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        Men�.SetActive(false);
    }
}
