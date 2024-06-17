using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] CharacterController cc;
    Vector3 input = Vector3.zero;

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
        input = new Vector3(0, 0, Input.GetAxisRaw("Vertical")).normalized;

    }

    void MovePlayer()
    {
        //rb.velocity = input * moveSpeed;
        input = transform.TransformDirection(input);
        cc.SimpleMove(input * moveSpeed);
    }

    void RotatePlayer()
    {
        transform.Rotate(0, Input.GetAxisRaw("Horizontal") * 10, 0);
    }
}
