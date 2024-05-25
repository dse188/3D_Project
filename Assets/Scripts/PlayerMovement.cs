using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] CharacterController cc;
    Vector3 input;
    //[SerializeField] bool isGrounded;
    [SerializeField] Transform feetPosition;
    [SerializeField] LayerMask groundLayer;

    private void Start()
    {
        
    }

    private void Update()
    {
        MoveInput();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void MoveInput()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

    }

    void JumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }

    void Move()
    {
        //rb.velocity = input * moveSpeed;
        cc.SimpleMove(input * moveSpeed);
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            
        }
    }

    bool IsGrounded()
    {
        return cc.isGrounded;
    }
}
