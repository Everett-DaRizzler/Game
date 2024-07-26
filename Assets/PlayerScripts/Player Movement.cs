using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
public float Rigidbody rb;
{
    Rigidbody rb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 400);
            
        }

        if(Input.GetKeyDown(KeyCode.W))
    {
    rb.velocity = Vector3.forward * 10f;
    }

        if(Input.GetKeyDown(KeyCode.S))
    {
    rb.velocity = Vector3.back * 10f;
    }

        if(Input.GetKeyDown(KeyCode.A))
    {
    rb.velocity = Vector3.left * 10f;
    }

        if(Input.GetKeyDown(KeyCode.D))
    {
    rb.velocity = Vector3.right * 10f;
    }

        
    }

    

}

