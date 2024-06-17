using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantGravity : MonoBehaviour
{
    [SerializeField] float gravity;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
    }
}
