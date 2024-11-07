using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HmdCameraMovement : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] Transform camOrgin;

    
    public void OnHmdPosition(InputValue value)
    {
        cam.transform.position = value.Get<Vector3>() + camOrgin.position;

    }

    public void OnHmdRotation(InputValue value)
    {
        cam.transform.rotation = camOrgin.rotation * value.Get<Quaternion>();
    }

}
