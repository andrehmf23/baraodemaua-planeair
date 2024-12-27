using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    [SerializeField] private float aeroSpeed = 5;
    [SerializeField] private float invert;
    [SerializeField] private float braveyInvert = 120;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * (aeroSpeed * Time.deltaTime);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        //print(horizontalInput);
        //print(verticalInput);
        invert += horizontalInput * braveyInvert * Time.deltaTime;

        float pitch = Mathf.Lerp(0, 20, Mathf.Abs(verticalInput)) * Mathf.Sign(verticalInput);
        float roll = Mathf.Lerp(0, 40, Mathf.Abs(horizontalInput)) * -Mathf.Sign(horizontalInput);
        transform.localRotation = Quaternion.Euler(Vector3.up * invert+ Vector3.right * pitch + Vector3.forward * roll);
        //print("Invert:" + transform.localRotation);
    }
}
