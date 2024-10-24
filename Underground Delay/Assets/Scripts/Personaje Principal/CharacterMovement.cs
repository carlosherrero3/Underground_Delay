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

    public HeartSystem heartSystem; //Referencia para el sript de la vida (HeartSystem).

    private bool isCrouching = false; //Estado de agachado;
    public float crouchHeight = 0.5f; //Altura del personaje cuando se agacha.
    private float originalHeight; //Altura original del personaje.
    private CapsuleCollider capsuleCollider; //Colider del personaje.

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        heartSystem = GetComponent<HeartSystem>(); //Obtiene la referencia.

        capsuleCollider = GetComponent<CapsuleCollider>();
        originalHeight = capsuleCollider.height; //Guarda la altura original del colider.
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

        if (Input.GetKeyDown(KeyCode.C)) //Si se presiona la tecla "c".
        {
            ToggleCrounch();
            Debug.Log("El personaje se esta agachando");
        }
    }

    public void Jump() //Función para que el personaje salte.
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void ToggleCrounch() //Alterna entre agacharse y levantarse
    {
        isCrouching = !isCrouching;
        capsuleCollider.height = isCrouching ? crouchHeight : originalHeight;
        if (isCrouching) //Ajusta el centro del collider al agacharse.
        {
            capsuleCollider.center = new Vector3(capsuleCollider.center.x, -0.5f, capsuleCollider.center.z);
        }
        else
        {
            capsuleCollider.center = new Vector3(capsuleCollider.center.x, 0, capsuleCollider.center.z); // Centro vuelve a y = 0
        }
        if (isCrouching) //Se asegura de que el personaje no baje al agacharse.
        {
            Vector3 position = transform.position;
            position.y += (originalHeight - crouchHeight) / 2; // Ajusta hacia arriba
            transform.position = position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DamagingObject")) //Verifica si el objeto es dañino.
        {
            heartSystem.TakeDamage(1);
        }
    }
}
