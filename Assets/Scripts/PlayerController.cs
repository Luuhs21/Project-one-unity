using Unity.Collections.Tests.CoreCLR.TestJobs;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //variables
    //Movement tuning (editable in Inspector)
    public float speed = 5.0f;
    public float turnSpeed = 5f;

    //Input System action exposed in Inspector for biding (WASD/Arrow Keys)
    public InputAction MoveAction;

    //current input (x = left/right, y = forward/back)
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //enable the MoveAction do it starts reading input
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // separeted methods that calls the vehicle actions
        moveCarForwardBack();
        moveCarRightLeft();
    }

    private void moveCarForwardBack()
    {
        
        //read the 2D vector from the MoveAction (y = vertical)
        moveInput = MoveAction.ReadValue<Vector2>();

        //move the vehicle forward / back along lozal z using the y component
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

    }

    private void moveCarRightLeft()
    {
        //read the 2D vector from the MoveAction (x = horizontal)
        moveInput = MoveAction.ReadValue<Vector2>();

        //Rotate around local Y using the x component 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);

        //move the vehicle left or right (test)
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * moveInput.x);
    }


}

