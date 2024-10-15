using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraCharacter : MonoBehaviour
{
    public GameObject jugador;
    public Vector2 m�nimo;
    public Vector2 m�ximo;
    public float suavizado;
    Vector2 velocity;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, jugador.transform.position.x, ref velocity.x, suavizado);
        float posY = Mathf.SmoothDamp(transform.position.y, jugador.transform.position.y, ref velocity.y, suavizado);
        transform.position = new Vector3(Mathf.Clamp(posX, m�nimo.x, m�ximo.x), Mathf.Clamp(posY, m�nimo.y, m�ximo.y), transform.position.z);
    }
}
