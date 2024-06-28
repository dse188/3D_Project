using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementStuffs : MonoBehaviour
{
    [SerializeField] CharacterController cc;
    [SerializeField] float speed;
    Vector3 input;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    void PlayerInput()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
    }

    void PlayerMove()
    {
        cc.SimpleMove(input * speed);
    }

    void PlayerRotate()
    {
        if(input.x > 0)
        {
            //transform.Rotate
        }
    }
}
