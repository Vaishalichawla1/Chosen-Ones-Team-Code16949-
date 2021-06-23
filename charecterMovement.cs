// All imports
using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class charecterMovement : MonoBehaviour
{
    [Header("Moving Player")]
    [SerializeField]

    // Attributes for moving the player.
    // Change these values with respect to your needs
    public bool is_walking = false;

    public Rigidbody PlayerRigidBody;

    [Header("Player Animation")]
    [SerializeField]

    // Set variable for player animation.
    public Animator animation_controller;

    void FixedUpdate()
    {            
        // This function is called at every frame
        MovetheCharecter();
    }

    // Function to move the charecter and play animation
    // while charecter is moving 
    void MovetheCharecter()
    {
        /*CharacterController controller = GetComponent<CharacterController>();
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            animation_controller.Play("Base Layer.Walk"); // Add the desired animation  {Format: LayerName.AnimationName} 
            if (controller.isGrounded)
            {
                moveDirection = new Vector3(0, 0, -Input.GetAxis("Vertical"));
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= walk_speed - 2.0f;
            }
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);

            //Rotate Player.
            if (Input.GetKey("a") || Input.GetKey("d"))
            {
                transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
            }
        }*/
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            animation_controller.Play("Base Layer.walk");
            if (Input.GetKey("w"))
            {
                PlayerRigidBody.AddForce(3000f * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey("a"))
            {
                PlayerRigidBody.AddForce(0, 0, 1500f * Time.deltaTime);
            }
            if (Input.GetKey("s"))
            {
                PlayerRigidBody.AddForce(-3000f * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey("d"))
            {
                PlayerRigidBody.AddForce(0, 0, -1500f * Time.deltaTime);
            }
        }
        else
        {
            animation_controller.Play("Base Layer.Idle");
        }
    }
}