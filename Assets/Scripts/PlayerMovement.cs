using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] CharacterController cc;
    Vector3 input;
    [SerializeField] Transform feetPosition;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] bool playerGrounded;

    //Jump stuffs
    [SerializeField] float jumpPower;
    [SerializeField] bool jump;
    Vector3 playerVector;
    [SerializeField] float gravityValue = -9.81f;

    private void Start()
    {
        
    }

    private void Update()
    {
        MoveInput();
        JumpInput();
    }

    private void FixedUpdate()
    {
        Move();
        Jump();
    }

    void MoveInput()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;

    }

    void JumpInput()
    {
        if(Input.GetKeyDown("Jump"))
        {
            jump = true;
        }
        if (!IsGrounded())
        {
            jump = false;
        }
    }

    void Move()
    {
        //rb.velocity = input * moveSpeed;
        cc.SimpleMove(input * moveSpeed);
    }

    void Jump()
    {
        if(IsGrounded() && jump)
        {
            //cc.SimpleMove(new Vector3(Input.GetAxisRaw("Horizontal"), jumpPower, Input.GetAxisRaw("Vertical")).normalized);
            playerVector.y += Mathf.Sqrt(jumpPower * -3.0f * gravityValue);
        }
    }

    bool IsGrounded()
    {
        return cc.isGrounded;
        //return playerGrounded = cc.isGrounded;
    }
}
