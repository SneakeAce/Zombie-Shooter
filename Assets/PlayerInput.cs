//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PlayerInput.inputactions
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

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""0a871a89-6c48-44a7-8103-a51a375185a2"",
            ""actions"": [
                {
                    ""name"": ""PlayerMovement"",
                    ""type"": ""Value"",
                    ""id"": ""9accd37c-2d45-4b56-8290-1f0c8b2e6329"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3da45ea7-73e7-4bd5-b137-0b500b9b28f3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e5066c10-b9a1-4bc5-a14f-36c76f76537a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0a24f65a-adee-4f0c-840f-0fe3e2199d09"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""327809b2-5fed-4eaa-906e-71629a50f847"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e0f7d9f5-aab9-42c0-aa6c-63fffcd80b28"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""MousePosition"",
            ""id"": ""48c98000-1a86-4344-9254-f9f5d678829d"",
            ""actions"": [
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""2b434a69-e7ec-4af0-a688-57cb99d4be0b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c67bbfa2-40ac-40cb-b7e9-240fd20e6f37"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""00d3571d-fa66-44c9-8a93-435b638bb407"",
            ""actions"": [
                {
                    ""name"": ""OpenOrCloseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""6fab9b44-2a77-4c77-9a6d-8d1b72bc0a69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ad6a39d5-9278-4e6c-b4df-0afce6bb48de"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenOrCloseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlacementObjectMode"",
            ""id"": ""842fe3a8-fc4b-400a-a88d-0f8b030699b2"",
            ""actions"": [
                {
                    ""name"": ""ActivatePlacementMode"",
                    ""type"": ""Button"",
                    ""id"": ""ea247fc1-9ba5-47c9-86ef-12a13948b282"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DeactivatePlacementMode"",
                    ""type"": ""Button"",
                    ""id"": ""9338ec5e-d8fa-4e50-a19f-c15a37cd79db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotatingObject"",
                    ""type"": ""Value"",
                    ""id"": ""48b6b4a1-ff3d-460c-b48f-c4dfe724ca4d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b55279ce-9776-42d0-a810-3e2e565347b7"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivatePlacementMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98b6efa1-87f3-4060-86e8-84fee6352ceb"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeactivatePlacementMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8da5db5a-5e78-49e9-bfee-6b22b8a2591a"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": ""Hold(duration=0.4,pressPoint=0.5)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeactivatePlacementMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c8eab99-f6bf-4149-9303-d16a49d1a5e7"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotatingObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_PlayerMovement = m_PlayerMovement.FindAction("PlayerMovement", throwIfNotFound: true);
        // MousePosition
        m_MousePosition = asset.FindActionMap("MousePosition", throwIfNotFound: true);
        m_MousePosition_MousePosition = m_MousePosition.FindAction("MousePosition", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_OpenOrCloseMenu = m_UI.FindAction("OpenOrCloseMenu", throwIfNotFound: true);
        // PlacementObjectMode
        m_PlacementObjectMode = asset.FindActionMap("PlacementObjectMode", throwIfNotFound: true);
        m_PlacementObjectMode_ActivatePlacementMode = m_PlacementObjectMode.FindAction("ActivatePlacementMode", throwIfNotFound: true);
        m_PlacementObjectMode_DeactivatePlacementMode = m_PlacementObjectMode.FindAction("DeactivatePlacementMode", throwIfNotFound: true);
        m_PlacementObjectMode_RotatingObject = m_PlacementObjectMode.FindAction("RotatingObject", throwIfNotFound: true);
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

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private List<IPlayerMovementActions> m_PlayerMovementActionsCallbackInterfaces = new List<IPlayerMovementActions>();
    private readonly InputAction m_PlayerMovement_PlayerMovement;
    public struct PlayerMovementActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerMovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayerMovement => m_Wrapper.m_PlayerMovement_PlayerMovement;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Add(instance);
            @PlayerMovement.started += instance.OnPlayerMovement;
            @PlayerMovement.performed += instance.OnPlayerMovement;
            @PlayerMovement.canceled += instance.OnPlayerMovement;
        }

        private void UnregisterCallbacks(IPlayerMovementActions instance)
        {
            @PlayerMovement.started -= instance.OnPlayerMovement;
            @PlayerMovement.performed -= instance.OnPlayerMovement;
            @PlayerMovement.canceled -= instance.OnPlayerMovement;
        }

        public void RemoveCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerMovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // MousePosition
    private readonly InputActionMap m_MousePosition;
    private List<IMousePositionActions> m_MousePositionActionsCallbackInterfaces = new List<IMousePositionActions>();
    private readonly InputAction m_MousePosition_MousePosition;
    public struct MousePositionActions
    {
        private @PlayerInput m_Wrapper;
        public MousePositionActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePosition => m_Wrapper.m_MousePosition_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_MousePosition; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MousePositionActions set) { return set.Get(); }
        public void AddCallbacks(IMousePositionActions instance)
        {
            if (instance == null || m_Wrapper.m_MousePositionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MousePositionActionsCallbackInterfaces.Add(instance);
            @MousePosition.started += instance.OnMousePosition;
            @MousePosition.performed += instance.OnMousePosition;
            @MousePosition.canceled += instance.OnMousePosition;
        }

        private void UnregisterCallbacks(IMousePositionActions instance)
        {
            @MousePosition.started -= instance.OnMousePosition;
            @MousePosition.performed -= instance.OnMousePosition;
            @MousePosition.canceled -= instance.OnMousePosition;
        }

        public void RemoveCallbacks(IMousePositionActions instance)
        {
            if (m_Wrapper.m_MousePositionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMousePositionActions instance)
        {
            foreach (var item in m_Wrapper.m_MousePositionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MousePositionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MousePositionActions @MousePosition => new MousePositionActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_OpenOrCloseMenu;
    public struct UIActions
    {
        private @PlayerInput m_Wrapper;
        public UIActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenOrCloseMenu => m_Wrapper.m_UI_OpenOrCloseMenu;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @OpenOrCloseMenu.started += instance.OnOpenOrCloseMenu;
            @OpenOrCloseMenu.performed += instance.OnOpenOrCloseMenu;
            @OpenOrCloseMenu.canceled += instance.OnOpenOrCloseMenu;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @OpenOrCloseMenu.started -= instance.OnOpenOrCloseMenu;
            @OpenOrCloseMenu.performed -= instance.OnOpenOrCloseMenu;
            @OpenOrCloseMenu.canceled -= instance.OnOpenOrCloseMenu;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);

    // PlacementObjectMode
    private readonly InputActionMap m_PlacementObjectMode;
    private List<IPlacementObjectModeActions> m_PlacementObjectModeActionsCallbackInterfaces = new List<IPlacementObjectModeActions>();
    private readonly InputAction m_PlacementObjectMode_ActivatePlacementMode;
    private readonly InputAction m_PlacementObjectMode_DeactivatePlacementMode;
    private readonly InputAction m_PlacementObjectMode_RotatingObject;
    public struct PlacementObjectModeActions
    {
        private @PlayerInput m_Wrapper;
        public PlacementObjectModeActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ActivatePlacementMode => m_Wrapper.m_PlacementObjectMode_ActivatePlacementMode;
        public InputAction @DeactivatePlacementMode => m_Wrapper.m_PlacementObjectMode_DeactivatePlacementMode;
        public InputAction @RotatingObject => m_Wrapper.m_PlacementObjectMode_RotatingObject;
        public InputActionMap Get() { return m_Wrapper.m_PlacementObjectMode; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlacementObjectModeActions set) { return set.Get(); }
        public void AddCallbacks(IPlacementObjectModeActions instance)
        {
            if (instance == null || m_Wrapper.m_PlacementObjectModeActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlacementObjectModeActionsCallbackInterfaces.Add(instance);
            @ActivatePlacementMode.started += instance.OnActivatePlacementMode;
            @ActivatePlacementMode.performed += instance.OnActivatePlacementMode;
            @ActivatePlacementMode.canceled += instance.OnActivatePlacementMode;
            @DeactivatePlacementMode.started += instance.OnDeactivatePlacementMode;
            @DeactivatePlacementMode.performed += instance.OnDeactivatePlacementMode;
            @DeactivatePlacementMode.canceled += instance.OnDeactivatePlacementMode;
            @RotatingObject.started += instance.OnRotatingObject;
            @RotatingObject.performed += instance.OnRotatingObject;
            @RotatingObject.canceled += instance.OnRotatingObject;
        }

        private void UnregisterCallbacks(IPlacementObjectModeActions instance)
        {
            @ActivatePlacementMode.started -= instance.OnActivatePlacementMode;
            @ActivatePlacementMode.performed -= instance.OnActivatePlacementMode;
            @ActivatePlacementMode.canceled -= instance.OnActivatePlacementMode;
            @DeactivatePlacementMode.started -= instance.OnDeactivatePlacementMode;
            @DeactivatePlacementMode.performed -= instance.OnDeactivatePlacementMode;
            @DeactivatePlacementMode.canceled -= instance.OnDeactivatePlacementMode;
            @RotatingObject.started -= instance.OnRotatingObject;
            @RotatingObject.performed -= instance.OnRotatingObject;
            @RotatingObject.canceled -= instance.OnRotatingObject;
        }

        public void RemoveCallbacks(IPlacementObjectModeActions instance)
        {
            if (m_Wrapper.m_PlacementObjectModeActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlacementObjectModeActions instance)
        {
            foreach (var item in m_Wrapper.m_PlacementObjectModeActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlacementObjectModeActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlacementObjectModeActions @PlacementObjectMode => new PlacementObjectModeActions(this);
    public interface IPlayerMovementActions
    {
        void OnPlayerMovement(InputAction.CallbackContext context);
    }
    public interface IMousePositionActions
    {
        void OnMousePosition(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnOpenOrCloseMenu(InputAction.CallbackContext context);
    }
    public interface IPlacementObjectModeActions
    {
        void OnActivatePlacementMode(InputAction.CallbackContext context);
        void OnDeactivatePlacementMode(InputAction.CallbackContext context);
        void OnRotatingObject(InputAction.CallbackContext context);
    }
}
