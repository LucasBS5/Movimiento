using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    private Transform cam;
    public Vector2 sensibility;

    void Start()
    {
        cam = transform.Find("MainCamera");
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        float EjeX = Input.GetAxis("Mouse X");
        float EjeY = Input.GetAxis("Mouse Y");


        if (EjeX !=0) {
            transform.Rotate(Vector3.up * EjeX * sensibility.x);
        }

        if (EjeY !=0) {
            float angle = (cam.localEulerAngles.x - EjeY * sensibility.y + 360) % 360;
            if (angle > 180) {
                angle -= 360;
            }
            angle = Mathf.Clamp(angle, -80, 80);

            cam.localEulerAngles = Vector3.right * angle;
        }
    }
}