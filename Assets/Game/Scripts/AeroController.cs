using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AeroController : MonoBehaviour
{
    [SerializeField] private float aeroSpeed = 5;
    [SerializeField] private float braveyInvert= 120;
    [SerializeField] private float invert;
    
    void Update()
    {
        //mover para frente
        transform.position += transform.forward * aeroSpeed * Time.deltaTime;

        //Pegar Imputs
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //invertida, 
        invert += horizontalInput * braveyInvert * Time.deltaTime;
        float pitch = Mathf.Lerp(0, 20, Mathf.Abs(verticalInput)) * Mathf.Sign(verticalInput);
        float roll = Mathf.Lerp(0, 30, Mathf.Abs(horizontalInput)) * -Mathf.Sign(horizontalInput);

        //aplicar rotação
        transform.localRotation = Quaternion.Euler(Vector3.up * invert + Vector3.right * pitch + Vector3.forward * roll);
    }
}