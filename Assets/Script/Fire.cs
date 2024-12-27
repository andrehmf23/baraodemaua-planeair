using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private float gunSpeed = 1;
    public Rigidbody fireout;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        fireout.AddForce(0,gunSpeed * Time.deltaTime,0);
        //GetComponent<Rigidbody>().AddForce(transform.forward*2000);
        
        //transform.position += transform.forward * (gunSpeed * Time.deltaTime);
    }
}