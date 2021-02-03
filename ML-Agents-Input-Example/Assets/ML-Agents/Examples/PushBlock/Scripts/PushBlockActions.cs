// GENERATED AUTOMATICALLY FROM 'Assets/ML-Agents/Examples/PushBlock/PushBlockActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PushBlockActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; set; }
    public @PushBlockActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PushBlockActions"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""03a2e5d4-ae81-47f1-a575-0779fb7da538"",
            ""actions"": [
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""ca5eb833-5dfb-4b7c-880d-6118bd5d1378"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""movement"",
                    ""type"": ""Value"",
                    ""id"": ""5f47cbc6-de46-4d33-93e2-2b1af4f5996d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""keyboard_move"",
                    ""id"": ""6bcba4bf-5ce0-4005-9e6a-0de2487211b0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""63da699e-b354-4e63-b0f8-26fb92abea41"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""39409748-9002-4aff-9a09-cdc05b9708ad"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0afe45fc-dc45-4310-9c73-7dc3c503addf"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""69fe0335-9e0c-495d-a90d-4b0fcbfd2b34"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ab696218-63cd-4eb8-9fe1-48a68e32e92f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7adcb138-5175-4cc4-addc-d2b02cb5f0de"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_jump = m_Movement.FindAction("jump", throwIfNotFound: true);
        m_Movement_movement = m_Movement.FindAction("movement", throwIfNotFound: true);
        m_MovementActions = new MovementActions(this);
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

    // Movement
    public InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    MovementActions m_MovementActions;
    public InputAction m_Movement_jump;
    public InputAction m_Movement_movement;
    public struct MovementActions
    {
        private @PushBlockActions m_Wrapper;
        public MovementActions(@PushBlockActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @jump => m_Wrapper.m_Movement_jump;
        public InputAction @movement => m_Wrapper.m_Movement_movement;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @movement.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovement;
                @movement.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovement;
                @movement.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @movement.started += instance.OnMovement;
                @movement.performed += instance.OnMovement;
                @movement.canceled += instance.OnMovement;
            }
        }
    }
    public MovementActions @Movement
    {
        get => m_MovementActions;
        set => m_MovementActions = value;
    }

    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
}