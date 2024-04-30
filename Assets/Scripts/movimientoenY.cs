using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float movementSpeed = 2f; // Velocidad de movimiento en el eje Y
    public float oscillationAmount = 0.5f; // Amplitud de oscilación
    public float oscillationSpeed = 2f; // Velocidad de oscilación

    private float initialY; // Posición Y inicial del objeto

    void Start()
    {
        initialY = transform.position.y; // Guarda la posición Y inicial
    }

    void Update()
    {
        // Movimiento en el eje Y
        float newY = Mathf.Sin(Time.time * oscillationSpeed) * oscillationAmount + initialY;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        // Movimiento constante en el eje Y
        transform.Translate(Vector3.up * Time.deltaTime * movementSpeed);
    }
}