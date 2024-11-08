using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSwitcher : MonoBehaviour
{
    [SerializeField] InputActionAsset _actionAsset;

    InputActionMap Vr;
    InputActionMap NotVr;

    [Tooltip("Curent Input Mode")]
    public bool vrMode;
    [Tooltip("Lock To Current Input Mode")]
    public bool vrModeLock;



    private void Start()
    {
        Vr = _actionAsset.FindActionMap("Vr");
        NotVr = _actionAsset.FindActionMap("NotVr");
    }

    private void Update()
    {
        if (!vrModeLock)
        {
            if (OVRManager.isHmdPresent)
            {
                vrMode = true;
            }
            else
            {
                vrMode = false;
            }
        }

        if (vrMode)
        {
            Vr.Enable();
            NotVr.Disable();
        }
        else
        {
            Vr.Disable();
            NotVr.Enable();
        }

    }


}
