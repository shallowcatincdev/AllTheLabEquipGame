using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HmdCameraMovement : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] Transform camOrgin;

    public bool vrActive;

    public void OnHmdPosition(InputValue value)
    {
        vrActive = true;
        cam.transform.position = value.Get<Vector3>() + camOrgin.position;
    }

    public void OnHmdRotation(InputValue value)
    {
        vrActive = true;
        cam.transform.rotation = camOrgin.rotation * value.Get<Quaternion>();
    }

    Vector2 rotation;

    public void OnControlerCam(InputValue value)
    {
        rotation = value.Get<Vector2>();
        rotation *= new Vector2(45, 5);
    }


    private void FixedUpdate()
    {
        if (!vrActive)
        {
            cam.transform.rotation = camOrgin.rotation * Quaternion.Euler(rotation.y * -1, rotation.x, 0);
        }

    }

}
