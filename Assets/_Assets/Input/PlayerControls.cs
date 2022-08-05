// GENERATED AUTOMATICALLY FROM 'Assets/_Assets/Input/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Space"",
            ""id"": ""415c6027-e8d2-4e44-8989-70d09d807482"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""40f92adc-81ed-4232-90ae-505ce5e73725"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9af9a5b8-1fda-453a-9e60-12d8def5f196"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Floated"",
                    ""type"": ""Value"",
                    ""id"": ""4769089b-32dd-442f-98c2-67a1cd87af96"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spawn"",
                    ""type"": ""Button"",
                    ""id"": ""40be6782-b38b-4b3b-8c42-be70bf366b56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Elevate"",
                    ""type"": ""Value"",
                    ""id"": ""9a180478-5f7e-4cc5-8afd-c3cc81ae9af4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""ac4f985b-4ad3-4cfc-92a9-140005c26840"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""d0ddb4f4-74b9-4375-b24f-6904e230033f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Release"",
                    ""type"": ""Button"",
                    ""id"": ""620ad679-bfe1-41d6-8528-d3fb4ef1e053"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""4377a43b-5f31-41a5-8287-520951ecabf2"",
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
                    ""id"": ""05b98105-c561-45fb-b50e-65a8604a1fb2"",
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
                    ""id"": ""0ef2f38b-d338-46a1-9533-c8887fbf3369"",
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
                    ""id"": ""c29a5bfe-c51a-4d61-b8d6-4edb4ff5e88a"",
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
                    ""id"": ""53a7e45c-77a9-4835-bbcd-3dbba79b8bcf"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0116fc84-f4e6-4f12-97ed-9df495c262c0"",
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
                    ""id"": ""d68f4d47-d48f-4713-902c-424a78493b4b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b3f793c3-7677-47d8-b2a0-cbc54c6b30c4"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e48be2cd-f9c3-472f-8133-12bcb53d4fd5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Elevate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9aade52f-f3be-43e6-a6b9-76032a52295a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Elevate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6fda90ba-d6fe-4308-b05e-0aa595934583"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Elevate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Right arrows"",
                    ""id"": ""96e4b479-8721-4d4b-a00b-f93e2e7feee3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f298b415-dedb-41ad-9bce-8d2279658d58"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9629c5e2-f4db-46f7-9914-b4140da0f110"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""919eb42b-8968-4997-b54e-bde1b8d32a7d"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1348e299-7b14-4543-8990-22a8b415c979"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b2d25c6f-1169-4bfb-8e2f-cdb929488b62"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Floated"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a6794d44-94d2-42c8-a70a-f3690e28dccc"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Floated"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a266a594-3389-4043-b63d-56293ac29f9d"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Floated"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Space
        m_Space = asset.FindActionMap("Space", throwIfNotFound: true);
        m_Space_Move = m_Space.FindAction("Move", throwIfNotFound: true);
        m_Space_Jump = m_Space.FindAction("Jump", throwIfNotFound: true);
        m_Space_Floated = m_Space.FindAction("Floated", throwIfNotFound: true);
        m_Space_Spawn = m_Space.FindAction("Spawn", throwIfNotFound: true);
        m_Space_Elevate = m_Space.FindAction("Elevate", throwIfNotFound: true);
        m_Space_Rotate = m_Space.FindAction("Rotate", throwIfNotFound: true);
        m_Space_Grab = m_Space.FindAction("Grab", throwIfNotFound: true);
        m_Space_Release = m_Space.FindAction("Release", throwIfNotFound: true);
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

    // Space
    private readonly InputActionMap m_Space;
    private ISpaceActions m_SpaceActionsCallbackInterface;
    private readonly InputAction m_Space_Move;
    private readonly InputAction m_Space_Jump;
    private readonly InputAction m_Space_Floated;
    private readonly InputAction m_Space_Spawn;
    private readonly InputAction m_Space_Elevate;
    private readonly InputAction m_Space_Rotate;
    private readonly InputAction m_Space_Grab;
    private readonly InputAction m_Space_Release;
    public struct SpaceActions
    {
        private @PlayerControls m_Wrapper;
        public SpaceActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Space_Move;
        public InputAction @Jump => m_Wrapper.m_Space_Jump;
        public InputAction @Floated => m_Wrapper.m_Space_Floated;
        public InputAction @Spawn => m_Wrapper.m_Space_Spawn;
        public InputAction @Elevate => m_Wrapper.m_Space_Elevate;
        public InputAction @Rotate => m_Wrapper.m_Space_Rotate;
        public InputAction @Grab => m_Wrapper.m_Space_Grab;
        public InputAction @Release => m_Wrapper.m_Space_Release;
        public InputActionMap Get() { return m_Wrapper.m_Space; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SpaceActions set) { return set.Get(); }
        public void SetCallbacks(ISpaceActions instance)
        {
            if (m_Wrapper.m_SpaceActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_SpaceActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_SpaceActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_SpaceActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_SpaceActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_SpaceActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_SpaceActionsCallbackInterface.OnJump;
                @Floated.started -= m_Wrapper.m_SpaceActionsCallbackInterface.OnFloated;
                @Floated.performed -= m_Wrapper.m_SpaceActionsCallbackInterface.OnFloated;
                @Floated.canceled -= m_Wrapper.m_SpaceActionsCallbackInterface.OnFloated;
                @Spawn.started -= m_Wrapper.m_SpaceActionsCallbackInterface.OnSpawn;
                @Spawn.performed -= m_Wrapper.m_SpaceActionsCallbackInterface.OnSpawn;
                @Spawn.canceled -= m_Wrapper.m_SpaceActionsCallbackInterface.OnSpawn;
                @Elevate.started -= m_Wrapper.m_SpaceActionsCallbackInterface.OnElevate;
                @Elevate.performed -= m_Wrapper.m_SpaceActionsCallbackInterface.OnElevate;
                @Elevate.canceled -= m_Wrapper.m_SpaceActionsCallbackInterface.OnElevate;
                @Rotate.started -= m_Wrapper.m_SpaceActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_SpaceActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_SpaceActionsCallbackInterface.OnRotate;
                @Grab.started -= m_Wrapper.m_SpaceActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_SpaceActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_SpaceActionsCallbackInterface.OnGrab;
                @Release.started -= m_Wrapper.m_SpaceActionsCallbackInterface.OnRelease;
                @Release.performed -= m_Wrapper.m_SpaceActionsCallbackInterface.OnRelease;
                @Release.canceled -= m_Wrapper.m_SpaceActionsCallbackInterface.OnRelease;
            }
            m_Wrapper.m_SpaceActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Floated.started += instance.OnFloated;
                @Floated.performed += instance.OnFloated;
                @Floated.canceled += instance.OnFloated;
                @Spawn.started += instance.OnSpawn;
                @Spawn.performed += instance.OnSpawn;
                @Spawn.canceled += instance.OnSpawn;
                @Elevate.started += instance.OnElevate;
                @Elevate.performed += instance.OnElevate;
                @Elevate.canceled += instance.OnElevate;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
                @Release.started += instance.OnRelease;
                @Release.performed += instance.OnRelease;
                @Release.canceled += instance.OnRelease;
            }
        }
    }
    public SpaceActions @Space => new SpaceActions(this);
    public interface ISpaceActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnFloated(InputAction.CallbackContext context);
        void OnSpawn(InputAction.CallbackContext context);
        void OnElevate(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnGrab(InputAction.CallbackContext context);
        void OnRelease(InputAction.CallbackContext context);
    }
}
