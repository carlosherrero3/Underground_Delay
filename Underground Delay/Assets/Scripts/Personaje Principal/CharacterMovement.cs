using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f; //Velocidad de movimiento.
    public CharacterController controller; //Variable para almacenar la dirección de movimiento.

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); //Movimiento horizontal
        Debug.Log(horizontal);
        Vector3 move = transform.right * horizontal;
        controller.Move(move * moveSpeed * Time.deltaTime);
    }
}
