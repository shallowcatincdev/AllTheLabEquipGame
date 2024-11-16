//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Input/Inputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Inputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""Vr"",
            ""id"": ""0a7da3a5-8a16-41c7-b335-4c2132a60a16"",
            ""actions"": [
                {
                    ""name"": ""HmdRotation"",
                    ""type"": ""Value"",
                    ""id"": ""47d647cc-5867-461a-b64e-b9b5b9075933"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MenuOpenClose"",
                    ""type"": ""Button"",
                    ""id"": ""19d37a7e-b6af-4ed4-99aa-ebc5e6df222b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HmdPosition"",
                    ""type"": ""Value"",
                    ""id"": ""cd955865-6e77-4400-b4ad-2cd5a03fd450"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ControlerCam"",
                    ""type"": ""Value"",
                    ""id"": ""dce74e91-a2f2-41f7-8ffd-1696378a2add"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""Value"",
                    ""id"": ""706a55b3-074d-4476-90a0-e01985c46b8d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GasBreak"",
                    ""type"": ""Value"",
                    ""id"": ""24df8ae2-5220-42a1-9567-34cc96e086df"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""039b33c7-3f11-4f00-86ef-4a1c0832e83b"",
                    ""path"": ""<XRHMD>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HmdRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e35a370f-2177-4308-a480-bf8bd76f9442"",
                    ""path"": ""<XRController>{RightHand}/{PrimaryAction}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuOpenClose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f0ce1f8-5ea9-45b5-8c49-2bb58059d2e7"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""MenuOpenClose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""GamePad"",
                    ""id"": ""37f3a311-db4d-400b-ae7e-049174fc174c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GasBreak"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4f409e21-f29c-47c4-be6d-47454b912681"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GasBreak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dd71afef-fa02-4607-86ee-ce86f01ae48c"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GasBreak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Xr"",
                    ""id"": ""26971a73-0296-44ba-8ec3-f5a997a6137b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GasBreak"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""903b42e6-9d53-456c-9a47-933e7c396615"",
                    ""path"": ""<XRController>{LeftHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GasBreak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""63275446-1b47-4384-abaa-c28b40ab76ef"",
                    ""path"": ""<XRController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GasBreak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1b6a788c-0970-41f6-b8e4-fda217a47644"",
                    ""path"": ""<XRController>/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a849d22f-7bb2-42a2-93fb-bc218d330d80"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""0c057552-ab42-43d3-86a6-7048c02adc9f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""ed4d7c7b-0cf5-4f9f-9f16-83daa06ffdb4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""14b98448-f5e2-4fb5-af57-b26bff265203"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c01b6fb4-f2cc-4d3b-b656-a56932ef0fd5"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ControlerCam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""783c7a8e-df43-4caa-a0b1-50ce26253a0c"",
                    ""path"": ""<XRController>{RightHand}/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ControlerCam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b1a37a4-d57f-4d73-b5b8-8b795fd54d23"",
                    ""path"": ""<XRHMD>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HmdPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Vr
        m_Vr = asset.FindActionMap("Vr", throwIfNotFound: true);
        m_Vr_HmdRotation = m_Vr.FindAction("HmdRotation", throwIfNotFound: true);
        m_Vr_MenuOpenClose = m_Vr.FindAction("MenuOpenClose", throwIfNotFound: true);
        m_Vr_HmdPosition = m_Vr.FindAction("HmdPosition", throwIfNotFound: true);
        m_Vr_ControlerCam = m_Vr.FindAction("ControlerCam", throwIfNotFound: true);
        m_Vr_Steer = m_Vr.FindAction("Steer", throwIfNotFound: true);
        m_Vr_GasBreak = m_Vr.FindAction("GasBreak", throwIfNotFound: true);
    }

    ~@Inputs()
    {
        UnityEngine.Debug.Assert(!m_Vr.enabled, "This will cause a leak and performance issues, Inputs.Vr.Disable() has not been called.");
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Vr
    private readonly InputActionMap m_Vr;
    private List<IVrActions> m_VrActionsCallbackInterfaces = new List<IVrActions>();
    private readonly InputAction m_Vr_HmdRotation;
    private readonly InputAction m_Vr_MenuOpenClose;
    private readonly InputAction m_Vr_HmdPosition;
    private readonly InputAction m_Vr_ControlerCam;
    private readonly InputAction m_Vr_Steer;
    private readonly InputAction m_Vr_GasBreak;
    public struct VrActions
    {
        private @Inputs m_Wrapper;
        public VrActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @HmdRotation => m_Wrapper.m_Vr_HmdRotation;
        public InputAction @MenuOpenClose => m_Wrapper.m_Vr_MenuOpenClose;
        public InputAction @HmdPosition => m_Wrapper.m_Vr_HmdPosition;
        public InputAction @ControlerCam => m_Wrapper.m_Vr_ControlerCam;
        public InputAction @Steer => m_Wrapper.m_Vr_Steer;
        public InputAction @GasBreak => m_Wrapper.m_Vr_GasBreak;
        public InputActionMap Get() { return m_Wrapper.m_Vr; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VrActions set) { return set.Get(); }
        public void AddCallbacks(IVrActions instance)
        {
            if (instance == null || m_Wrapper.m_VrActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_VrActionsCallbackInterfaces.Add(instance);
            @HmdRotation.started += instance.OnHmdRotation;
            @HmdRotation.performed += instance.OnHmdRotation;
            @HmdRotation.canceled += instance.OnHmdRotation;
            @MenuOpenClose.started += instance.OnMenuOpenClose;
            @MenuOpenClose.performed += instance.OnMenuOpenClose;
            @MenuOpenClose.canceled += instance.OnMenuOpenClose;
            @HmdPosition.started += instance.OnHmdPosition;
            @HmdPosition.performed += instance.OnHmdPosition;
            @HmdPosition.canceled += instance.OnHmdPosition;
            @ControlerCam.started += instance.OnControlerCam;
            @ControlerCam.performed += instance.OnControlerCam;
            @ControlerCam.canceled += instance.OnControlerCam;
            @Steer.started += instance.OnSteer;
            @Steer.performed += instance.OnSteer;
            @Steer.canceled += instance.OnSteer;
            @GasBreak.started += instance.OnGasBreak;
            @GasBreak.performed += instance.OnGasBreak;
            @GasBreak.canceled += instance.OnGasBreak;
        }

        private void UnregisterCallbacks(IVrActions instance)
        {
            @HmdRotation.started -= instance.OnHmdRotation;
            @HmdRotation.performed -= instance.OnHmdRotation;
            @HmdRotation.canceled -= instance.OnHmdRotation;
            @MenuOpenClose.started -= instance.OnMenuOpenClose;
            @MenuOpenClose.performed -= instance.OnMenuOpenClose;
            @MenuOpenClose.canceled -= instance.OnMenuOpenClose;
            @HmdPosition.started -= instance.OnHmdPosition;
            @HmdPosition.performed -= instance.OnHmdPosition;
            @HmdPosition.canceled -= instance.OnHmdPosition;
            @ControlerCam.started -= instance.OnControlerCam;
            @ControlerCam.performed -= instance.OnControlerCam;
            @ControlerCam.canceled -= instance.OnControlerCam;
            @Steer.started -= instance.OnSteer;
            @Steer.performed -= instance.OnSteer;
            @Steer.canceled -= instance.OnSteer;
            @GasBreak.started -= instance.OnGasBreak;
            @GasBreak.performed -= instance.OnGasBreak;
            @GasBreak.canceled -= instance.OnGasBreak;
        }

        public void RemoveCallbacks(IVrActions instance)
        {
            if (m_Wrapper.m_VrActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IVrActions instance)
        {
            foreach (var item in m_Wrapper.m_VrActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_VrActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public VrActions @Vr => new VrActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IVrActions
    {
        void OnHmdRotation(InputAction.CallbackContext context);
        void OnMenuOpenClose(InputAction.CallbackContext context);
        void OnHmdPosition(InputAction.CallbackContext context);
        void OnControlerCam(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
        void OnGasBreak(InputAction.CallbackContext context);
    }
}
