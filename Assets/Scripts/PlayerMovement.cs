using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 playerVelocity;
    public float speed = 5f;

    public float gravity = -9.8f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = Input.GetAxis("Horizontal");
        moveDirection.z = Input.GetAxis("Vertical");
        characterController.Move(((transform.TransformDirection(moveDirection)) * speed) * Time.deltaTime);
       
        playerVelocity.y += gravity * Time.deltaTime;
        if (characterController.isGrounded && playerVelocity.y < 0)
            playerVelocity.y = -0.5f;
        characterController.Move(playerVelocity);

       
        
    }
}
