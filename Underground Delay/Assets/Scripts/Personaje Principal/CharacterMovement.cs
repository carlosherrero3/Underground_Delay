using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f; //Velocidad de movimiento.
    public Rigidbody rb; //Variable para almacenar la dirección de movimiento.

    public float jumpForce = 5f;
    private bool isGrounded;
    public float groundDistance = 0.01f;
    public Transform groundCheck;
    public LayerMask groundMask;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); //Movimiento horizontal
        Debug.Log(horizontal);
        Vector3 move = transform.right * horizontal * moveSpeed;
        rb.velocity = new Vector3(move.x, rb.velocity.y, rb.velocity.z);

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //Comprueba si el personaje esta en el suelo.
        if (isGrounded && Input.GetButtonDown("Jump")) //Salta si esta en el suelo y se presiona la tecla.
        {
            Jump();
        }
    }

    public void Jump() //Función para que el personaje salte.
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
