//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Devs/Hamzeh/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""650f8507-af53-4467-bb56-7082fca760ec"",
            ""actions"": [
                {
                    ""name"": ""Player1Move"",
                    ""type"": ""Value"",
                    ""id"": ""2d9b3ad3-8326-4012-ba20-26dcc7b3f29a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Player1Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b2166b60-caa8-4ce3-803f-d8d6477e8567"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player2Move"",
                    ""type"": ""Value"",
                    ""id"": ""a0822035-4286-42cc-b014-2c711befec3d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Player2Jump"",
                    ""type"": ""Button"",
                    ""id"": ""28cb6fa2-80f1-4ee5-8a4e-f782eb0b349d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""21855d86-d6f0-4d9c-9b98-09294e90062d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""84ce7092-4f1a-45a2-b6b1-a58834cf9427"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""c759aa8f-6c90-4df1-9a65-1f090540f9ab"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""b09fe036-5410-42d1-b7e3-e09d6020b14c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""cfa795db-e0f7-44ab-aae3-334cec3c5dde"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9dfa87bd-13b5-4046-a543-2d80a3e82b14"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c7a8287d-1aa4-49a4-a4f4-1cb59e13a6d7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""a29fa77c-19ee-4716-a8c5-ec4db28758e4"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""0090bb38-ea89-456e-9385-922946f2adf7"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""fbcce394-8fdb-496b-b382-0ba93a134a0e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""d866bf7b-cac3-4de7-89f6-5f375d415917"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4408362a-6129-4534-ab8c-fb794ee93051"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Player1Move = m_Gameplay.FindAction("Player1Move", throwIfNotFound: true);
        m_Gameplay_Player1Jump = m_Gameplay.FindAction("Player1Jump", throwIfNotFound: true);
        m_Gameplay_Player2Move = m_Gameplay.FindAction("Player2Move", throwIfNotFound: true);
        m_Gameplay_Player2Jump = m_Gameplay.FindAction("Player2Jump", throwIfNotFound: true);
    }

    ~@PlayerControls()
    {
        UnityEngine.Debug.Assert(!m_Gameplay.enabled, "This will cause a leak and performance issues, PlayerControls.Gameplay.Disable() has not been called.");
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Player1Move;
    private readonly InputAction m_Gameplay_Player1Jump;
    private readonly InputAction m_Gameplay_Player2Move;
    private readonly InputAction m_Gameplay_Player2Jump;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Player1Move => m_Wrapper.m_Gameplay_Player1Move;
        public InputAction @Player1Jump => m_Wrapper.m_Gameplay_Player1Jump;
        public InputAction @Player2Move => m_Wrapper.m_Gameplay_Player2Move;
        public InputAction @Player2Jump => m_Wrapper.m_Gameplay_Player2Jump;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Player1Move.started += instance.OnPlayer1Move;
            @Player1Move.performed += instance.OnPlayer1Move;
            @Player1Move.canceled += instance.OnPlayer1Move;
            @Player1Jump.started += instance.OnPlayer1Jump;
            @Player1Jump.performed += instance.OnPlayer1Jump;
            @Player1Jump.canceled += instance.OnPlayer1Jump;
            @Player2Move.started += instance.OnPlayer2Move;
            @Player2Move.performed += instance.OnPlayer2Move;
            @Player2Move.canceled += instance.OnPlayer2Move;
            @Player2Jump.started += instance.OnPlayer2Jump;
            @Player2Jump.performed += instance.OnPlayer2Jump;
            @Player2Jump.canceled += instance.OnPlayer2Jump;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Player1Move.started -= instance.OnPlayer1Move;
            @Player1Move.performed -= instance.OnPlayer1Move;
            @Player1Move.canceled -= instance.OnPlayer1Move;
            @Player1Jump.started -= instance.OnPlayer1Jump;
            @Player1Jump.performed -= instance.OnPlayer1Jump;
            @Player1Jump.canceled -= instance.OnPlayer1Jump;
            @Player2Move.started -= instance.OnPlayer2Move;
            @Player2Move.performed -= instance.OnPlayer2Move;
            @Player2Move.canceled -= instance.OnPlayer2Move;
            @Player2Jump.started -= instance.OnPlayer2Jump;
            @Player2Jump.performed -= instance.OnPlayer2Jump;
            @Player2Jump.canceled -= instance.OnPlayer2Jump;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnPlayer1Move(InputAction.CallbackContext context);
        void OnPlayer1Jump(InputAction.CallbackContext context);
        void OnPlayer2Move(InputAction.CallbackContext context);
        void OnPlayer2Jump(InputAction.CallbackContext context);
    }
}
