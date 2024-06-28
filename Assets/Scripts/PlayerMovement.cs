using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotationSpeed;
    [SerializeField] CharacterController cc;
    Vector3 input = Vector3.zero;
    float verticalInput;

    private void Start()
    {
        
    }

    private void Update()
    {
        MoveInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
        RotatePlayer();
    }

    void MoveInput()
    {
        //input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;

        verticalInput = Input.GetAxisRaw("Vertical");
        input = new Vector3(0, 0, verticalInput).normalized;

    }

    void MovePlayer()
    {
        //rb.velocity = input * moveSpeed;
        input = transform.TransformDirection(input);
        cc.SimpleMove(input * moveSpeed);
    }

    void RotatePlayer()
    {
        transform.Rotate(0, Input.GetAxisRaw("Horizontal") * rotationSpeed, 0);
        /*if(verticalInput < 0)
        {
            transform.Rotate(0, 1 * rotationSpeed, 0);
        }*/
    }
}
