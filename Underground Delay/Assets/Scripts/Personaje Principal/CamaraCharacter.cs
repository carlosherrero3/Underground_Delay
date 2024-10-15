using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraCharacter : MonoBehaviour
{
    public GameObject jugador;
    public Vector2 mínimo;
    public Vector2 máximo;
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
        transform.position = new Vector3(Mathf.Clamp(posX, mínimo.x, máximo.x), Mathf.Clamp(posY, mínimo.y, máximo.y), transform.position.z);
    }
}
