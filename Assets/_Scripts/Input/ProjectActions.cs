//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/_Scripts/Input/ProjectActions.inputactions
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

public partial class @ProjectActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ProjectActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ProjectActions"",
    ""maps"": [
        {
            ""name"": ""Overworld"",
            ""id"": ""9055505f-0624-4740-b8f4-86375f6fc2e7"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2421a5a3-77f4-4d12-beed-ae140bc893ed"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""bc2f3be9-34ef-463c-95b8-7df6f3753bd6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""8e865c70-eeb4-4d67-895d-5327c6f0bc6e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c1d6a9f7-19bb-4893-aaeb-e35fe7cb327c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""722f4a31-145a-4250-9e7f-7b5ad176f3b9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""20b7d451-7c47-4e3e-95df-145120a8a709"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f50a29a4-436b-4fb6-b9a5-51d286604780"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""752e220d-b23b-4203-a16a-5c54aea294a9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""04918a8c-c7e6-42ac-8d45-6d3424ca2f75"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9ad41b9d-d20b-494b-8a42-2286d345683f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""604e6e7b-ccee-458a-991c-38804b454b1f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9210f082-97ab-44b3-ac8a-5eb4050980ba"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""73ccc4dd-e097-4385-998b-eb602ddf9dc8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""56466138-dc87-4c01-954c-bdb4b746073c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""40b92616-e8a4-4ff9-a483-893c9e806a6b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2202ce2c-e7bd-4068-847c-645506e5ec3f"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8454122-d8ac-4d6f-bfc2-02176cca5e11"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bfb87ed-eab2-460c-babb-b6335351a20b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b55527b2-e3d6-4022-8a9f-a230329057b8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac46b1de-e235-4a61-beb3-645d9960fe2d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Overworld
        m_Overworld = asset.FindActionMap("Overworld", throwIfNotFound: true);
        m_Overworld_Move = m_Overworld.FindAction("Move", throwIfNotFound: true);
        m_Overworld_Drop = m_Overworld.FindAction("Drop", throwIfNotFound: true);
        m_Overworld_Attack = m_Overworld.FindAction("Attack", throwIfNotFound: true);
        m_Overworld_Jump = m_Overworld.FindAction("Jump", throwIfNotFound: true);
    }

    ~@ProjectActions()
    {
        UnityEngine.Debug.Assert(!m_Overworld.enabled, "This will cause a leak and performance issues, ProjectActions.Overworld.Disable() has not been called.");
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

    // Overworld
    private readonly InputActionMap m_Overworld;
    private List<IOverworldActions> m_OverworldActionsCallbackInterfaces = new List<IOverworldActions>();
    private readonly InputAction m_Overworld_Move;
    private readonly InputAction m_Overworld_Drop;
    private readonly InputAction m_Overworld_Attack;
    private readonly InputAction m_Overworld_Jump;
    public struct OverworldActions
    {
        private @ProjectActions m_Wrapper;
        public OverworldActions(@ProjectActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Overworld_Move;
        public InputAction @Drop => m_Wrapper.m_Overworld_Drop;
        public InputAction @Attack => m_Wrapper.m_Overworld_Attack;
        public InputAction @Jump => m_Wrapper.m_Overworld_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Overworld; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OverworldActions set) { return set.Get(); }
        public void AddCallbacks(IOverworldActions instance)
        {
            if (instance == null || m_Wrapper.m_OverworldActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_OverworldActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Drop.started += instance.OnDrop;
            @Drop.performed += instance.OnDrop;
            @Drop.canceled += instance.OnDrop;
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IOverworldActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Drop.started -= instance.OnDrop;
            @Drop.performed -= instance.OnDrop;
            @Drop.canceled -= instance.OnDrop;
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IOverworldActions instance)
        {
            if (m_Wrapper.m_OverworldActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IOverworldActions instance)
        {
            foreach (var item in m_Wrapper.m_OverworldActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_OverworldActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public OverworldActions @Overworld => new OverworldActions(this);
    public interface IOverworldActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}