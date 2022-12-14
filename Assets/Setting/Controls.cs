//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.1
//     from Assets/Setting/Controls.inputactions
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

namespace TPC
{
    public partial class @Controls : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Controls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""7c80348f-79de-4a61-8ed1-65ba7592383d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ada571bb-232f-46e9-a5b7-6f7ec205277f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4f51b07e-f10b-4bb4-a15b-dc830c0a2922"",
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
                    ""id"": ""6f03ccf2-ddac-4917-acf4-94d732d8068f"",
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
                    ""id"": ""76a71646-7335-4fa6-91dc-ecbb90c69875"",
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
                    ""id"": ""e53cfcf2-afd3-4216-b7ca-538d6136970d"",
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
                    ""id"": ""cb582cde-26aa-4609-869d-d885abbc6c8f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Action"",
            ""id"": ""27408eac-5cd3-4765-9d81-9cdec799ea7d"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6602a06d-61c6-42d0-a2bd-1e8363a9735d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a79bd04c-f1b7-4306-b481-e51b00b8a5a5"",
                    ""path"": """",
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
            // Move
            m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
            m_Move_Move = m_Move.FindAction("Move", throwIfNotFound: true);
            // Action
            m_Action = asset.FindActionMap("Action", throwIfNotFound: true);
            m_Action_Jump = m_Action.FindAction("Jump", throwIfNotFound: true);
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

        // Move
        private readonly InputActionMap m_Move;
        private IMoveActions m_MoveActionsCallbackInterface;
        private readonly InputAction m_Move_Move;
        public struct MoveActions
        {
            private @Controls m_Wrapper;
            public MoveActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Move_Move;
            public InputActionMap Get() { return m_Wrapper.m_Move; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
            public void SetCallbacks(IMoveActions instance)
            {
                if (m_Wrapper.m_MoveActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMove;
                }
                m_Wrapper.m_MoveActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                }
            }
        }
        public MoveActions @Move => new MoveActions(this);

        // Action
        private readonly InputActionMap m_Action;
        private IActionActions m_ActionActionsCallbackInterface;
        private readonly InputAction m_Action_Jump;
        public struct ActionActions
        {
            private @Controls m_Wrapper;
            public ActionActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Jump => m_Wrapper.m_Action_Jump;
            public InputActionMap Get() { return m_Wrapper.m_Action; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(ActionActions set) { return set.Get(); }
            public void SetCallbacks(IActionActions instance)
            {
                if (m_Wrapper.m_ActionActionsCallbackInterface != null)
                {
                    @Jump.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnJump;
                }
                m_Wrapper.m_ActionActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                }
            }
        }
        public ActionActions @Action => new ActionActions(this);
        public interface IMoveActions
        {
            void OnMove(InputAction.CallbackContext context);
        }
        public interface IActionActions
        {
            void OnJump(InputAction.CallbackContext context);
        }
    }
}
