using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    public float MovementSpeed;
    public bool isJumping; 
    public bool isGrounded; 

    Vector3 movementVect;
    CharacterController controller;
    void Start() 
    {
        isGrounded = false;
        isJumping = false; 
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        PlayerMovement();
    }               

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        movementVect = new Vector3(hor, 0.0f, ver);
        MovementSpeed = (Input.GetKey(KeyCode.LeftShift))? 15f:10f;
        movementVect = movementVect * MovementSpeed * Time.deltaTime;
        // controller.detectCollisions = true;
        transform.Translate(movementVect); 
          
     }
}
