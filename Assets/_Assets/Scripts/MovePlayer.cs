using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    //calling the input actions
    PlayerControls _playerControls;

    //define object to spawn and spawn location
    public GameObject objectToSpawn;
    public GameObject spawnPoint;

    //defines the move and rotate speed for the movement
    float moveSpeed = 4f;
    float turnSpeed = 5f;
    //[SerializeField] Quaternion currentRotation;
    public float rotationAmount;

    //defines the jump power
    [SerializeField] float jumpPower = 10f;

    //defines the rigidbody
    Rigidbody _body;

    private void Awake()
    {
        //waking the input action
        _playerControls = new PlayerControls();

        //getting the rigibody
        _body = GetComponent<Rigidbody>();
    }


    private void OnEnable()
    {
        //enabling the input action on enable
        _playerControls.Enable();

        //subscribing the jump input
        _playerControls.Space.Jump.performed += onJump;

        //subscribing the spawn input
        _playerControls.Space.Spawn.performed += Spawn;

    }

    private void OnDisable()
    {
        //disabling the inpu action on disable
        _playerControls.Disable();

        //unsubscribing the jump input
        _playerControls.Space.Jump.performed -= onJump;

        //unsubscribing the spawn input
        _playerControls.Space.Spawn.performed -= Spawn;

    }
    private void Spawn(InputAction.CallbackContext obj)
    {
        Instantiate(objectToSpawn, spawnPoint.transform);
    }

    private void onJump(InputAction.CallbackContext obj)
    {
        //add force to rigidbody
        //AddForce follow by Vector 3 (x, y, z); Vector3.up = Vector3 (0, 1, 0)
        //because onJump is a one time action, we use Impluse
        _body.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);

    }


    // Update is called once per frame
    void Update()
    {
        //give the vector2 a name call "movement"
        //Vector 2 is two floats value; A and D is on X axis, W and S is on Y axis;
        //float elevation is new y axis; 
        Vector2 movement = _playerControls.Space.Move.ReadValue<Vector2>() * moveSpeed * Time.deltaTime;

        float leftRightMovement = movement.x;

        float forwardBackwardMovement = movement.y;

        //give the vector2 a name call "elevation"
        Vector2 elevation = _playerControls.Space.Elevate.ReadValue<Vector2>() * moveSpeed * Time.deltaTime;
        transform.Translate(leftRightMovement, elevation.y, forwardBackwardMovement);

        //give the vector2 a name call "rotate"
        //turnSpeed and rotationAmount is defined at the beginning
        Vector2 rotate = _playerControls.Space.Rotate.ReadValue<Vector2>() * turnSpeed * Time.deltaTime;
        transform.Rotate(0, rotate.x * rotationAmount, 0);
    }
}
