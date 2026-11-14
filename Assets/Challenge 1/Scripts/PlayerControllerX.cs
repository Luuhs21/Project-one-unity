using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 5.0f;

    public InputAction MoveAction;

    public Vector2 MoveInput;

    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        MoveInput = MoveAction.ReadValue<Vector2>();
       
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed );

        // tilt the plane up/down based on up/down arrow keys
        //transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * MoveInput.y);
        transform.Rotate(Vector3.right, Time.deltaTime * rotationSpeed * MoveInput.y);
    }
}
