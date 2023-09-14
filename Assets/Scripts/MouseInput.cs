// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Mouse.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MouseInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MouseInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Mouse"",
    ""maps"": [
        {
            ""name"": ""Mouse"",
            ""id"": ""8a0af976-91b1-4da5-9ef2-0ada838d229f"",
            ""actions"": [
                {
                    ""name"": ""MouseClick"",
                    ""type"": ""Button"",
                    ""id"": ""bfb506d5-98e7-4678-b5d8-6c87712b51c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""287d8bdd-ad6a-4bea-9f62-c030b852b2af"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fdeae5a4-c60e-4c11-b20e-25bb373f7a4a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd014596-a86f-4eb8-862d-2c8d579fbfe3"",
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
            ""name"": ""Text"",
            ""id"": ""b377e6d1-52be-47bd-8579-0386b7bd210e"",
            ""actions"": [
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""8414d544-62e5-4498-b07f-5167a4353b69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2f0e00aa-15c7-42de-980e-bd44837cee0a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GenericMove"",
            ""id"": ""06c49340-19e0-4e3e-82c7-e402ed301369"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""acd9ca71-8418-436e-a249-6102f0d24662"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""4b2090db-5901-44d1-9787-e9be8fff0273"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""36415e91-d464-4aee-b674-4f63ea447463"",
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
                    ""id"": ""7b0ec809-349f-4900-bc00-1e2387dcb9ce"",
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
                    ""id"": ""4503e94a-03f1-4fad-81a2-c8522e987671"",
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
                    ""id"": ""40c222b9-2b1e-463d-b100-357e36a320b9"",
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
                    ""id"": ""c20ebb92-36d7-4505-bc9b-6c05b9059ced"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""812c8f6d-eb1f-4ed2-b0cd-a572e3c742cd"",
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
                    ""id"": ""645fd7b2-6fee-4499-aa5b-67d0a9ba5e95"",
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
                    ""id"": ""0b414912-c225-46cc-84d9-c7169f828db4"",
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
                    ""id"": ""58e1c069-26d4-4e06-b370-250cff82255f"",
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
                    ""id"": ""eaf0c419-cadd-4045-ad42-6087ef16c582"",
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
                    ""id"": ""255eb6b1-6762-4530-82f9-819f9c5d60d6"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_MouseClick = m_Mouse.FindAction("MouseClick", throwIfNotFound: true);
        m_Mouse_MousePosition = m_Mouse.FindAction("MousePosition", throwIfNotFound: true);
        // Text
        m_Text = asset.FindActionMap("Text", throwIfNotFound: true);
        m_Text_Submit = m_Text.FindAction("Submit", throwIfNotFound: true);
        // GenericMove
        m_GenericMove = asset.FindActionMap("GenericMove", throwIfNotFound: true);
        m_GenericMove_Move = m_GenericMove.FindAction("Move", throwIfNotFound: true);
        m_GenericMove_Interact = m_GenericMove.FindAction("Interact", throwIfNotFound: true);
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

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_MouseClick;
    private readonly InputAction m_Mouse_MousePosition;
    public struct MouseActions
    {
        private @MouseInput m_Wrapper;
        public MouseActions(@MouseInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseClick => m_Wrapper.m_Mouse_MouseClick;
        public InputAction @MousePosition => m_Wrapper.m_Mouse_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @MouseClick.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseClick;
                @MouseClick.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseClick;
                @MouseClick.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseClick;
                @MousePosition.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseClick.started += instance.OnMouseClick;
                @MouseClick.performed += instance.OnMouseClick;
                @MouseClick.canceled += instance.OnMouseClick;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);

    // Text
    private readonly InputActionMap m_Text;
    private ITextActions m_TextActionsCallbackInterface;
    private readonly InputAction m_Text_Submit;
    public struct TextActions
    {
        private @MouseInput m_Wrapper;
        public TextActions(@MouseInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Submit => m_Wrapper.m_Text_Submit;
        public InputActionMap Get() { return m_Wrapper.m_Text; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TextActions set) { return set.Get(); }
        public void SetCallbacks(ITextActions instance)
        {
            if (m_Wrapper.m_TextActionsCallbackInterface != null)
            {
                @Submit.started -= m_Wrapper.m_TextActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_TextActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_TextActionsCallbackInterface.OnSubmit;
            }
            m_Wrapper.m_TextActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
            }
        }
    }
    public TextActions @Text => new TextActions(this);

    // GenericMove
    private readonly InputActionMap m_GenericMove;
    private IGenericMoveActions m_GenericMoveActionsCallbackInterface;
    private readonly InputAction m_GenericMove_Move;
    private readonly InputAction m_GenericMove_Interact;
    public struct GenericMoveActions
    {
        private @MouseInput m_Wrapper;
        public GenericMoveActions(@MouseInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_GenericMove_Move;
        public InputAction @Interact => m_Wrapper.m_GenericMove_Interact;
        public InputActionMap Get() { return m_Wrapper.m_GenericMove; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GenericMoveActions set) { return set.Get(); }
        public void SetCallbacks(IGenericMoveActions instance)
        {
            if (m_Wrapper.m_GenericMoveActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GenericMoveActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GenericMoveActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GenericMoveActionsCallbackInterface.OnMove;
                @Interact.started -= m_Wrapper.m_GenericMoveActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GenericMoveActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GenericMoveActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_GenericMoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public GenericMoveActions @GenericMove => new GenericMoveActions(this);
    public interface IMouseActions
    {
        void OnMouseClick(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
    public interface ITextActions
    {
        void OnSubmit(InputAction.CallbackContext context);
    }
    public interface IGenericMoveActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
