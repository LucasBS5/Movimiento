using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocity = 2f;

    
    private Rigidbody rb; // Referencia al Rigidbody
    private Transform cam;

    void Start()
    {
        cam = transform.Find("MainCamera");
        rb = GetComponent<Rigidbody>(); // Obtiene el Rigidbody
    }

    void Update()
    {
        Vector3 forward = cam.TransformDirection(Vector3.forward);
        forward.y = 0;
        forward.Normalize(); 

        transform.position += forward * velocity * Time.deltaTime;
    }
}
