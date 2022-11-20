using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPC
{
    public class CharacterController : MonoBehaviour
    {
        public Vector3 Position
        {
            get { return transform.position; }
            set { transform.position = value; }
        }
        public Quaternion Rotation
        {
            get { return transform.rotation; }
            set { transform.rotation = value; }
        }
        public Vector3 Forward
        {
            get { return transform.forward; }
            set { transform.forward = value; }
        }
        public Vector3 Velocity
        {
            get { return _rigidbody.velocity; }
            set { _rigidbody.velocity = value; }
        }

        [Tooltip("Cameara controller moved by an input")]
        public GameObject CameraObject;
        [Tooltip("Character Model")]
        public GameObject CharacterModel;
        [Tooltip("Character Pivot")]
        public Transform Pivot;
        [Tooltip("Layers where the player can stand")]
        public LayerMask GroundLayerMask;

        [Tooltip("Distance from the player feet used to check if the player is touching the ground")]
        public float GroundCheckerThrashold = 0.1f;

        public float DampSpeedup = 0.1f;
        public float DampSpeeddown = 0.1f;
        public float DampRotation = 0.1f;

        public bool IsSprint;

        private float _speed = 5f;

        private float _targetAngel;
        private Vector2 _input;
        private Vector3 _inputDirection;
        private Vector3 _characterDirection;
        private Vector3 _currentVelocity;
        private float _turnSmoothVelocity;

        private Vector3 _prevNormalVector;
        private Vector3 _normalVector;

        private bool _prevGrounded;
        private bool _isGrounded;
        private float _originalColliderHeight = 2.0f;

        private Rigidbody _rigidbody;
        private CapsuleCollider _collider;

        // Start is called before the first frame update
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        private void Update()
        {

        }

        private void FixedUpdate()
        {
            handleMovement();
            handleRotation();
        }

        #region MOVEMENT
        private void handleMovement()
        {
            if (_input.magnitude > 0)
            {
                if (IsSprint)
                    Velocity = Vector3.SmoothDamp(Velocity, Forward * _speed, ref _currentVelocity, DampSpeedup);
                else
                    Velocity = Vector3.SmoothDamp(Velocity, Forward * _speed, ref _currentVelocity, DampSpeedup);
            }
            else
            {
                Velocity = Vector3.SmoothDamp(Velocity, Vector3.zero, ref _currentVelocity, DampSpeeddown);
            }
        }

        private void handleRotation()
        {
            Rotation = Quaternion.Euler(0, _targetAngel, 0f);
            float angle = Mathf.SmoothDampAngle(CharacterModel.transform.eulerAngles.y, _targetAngel, ref _turnSmoothVelocity, DampRotation);
            CharacterModel.transform.rotation = Quaternion.Euler(0f, angle, 0f);
        }
        #endregion

        private void checkGrounded()
        {
            _prevGrounded = _isGrounded;
            _isGrounded = Physics.CheckSphere(Position - new Vector3(0, _originalColliderHeight / 2f, 0), GroundCheckerThrashold, GroundLayerMask);
        }
    }
}