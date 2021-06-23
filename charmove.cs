using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class charmove : MonoBehaviour
{
    [Header("Moving Player")]
    [SerializeField]

    // Attributes for moving the player.
    // Change these values with respect to your needs
    public float walk_speed = 10.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 10.0F;
    public float rotateSpeed = 2.0F;
    private Vector3 moveDirection = Vector3.zero;
    public Rigidbody playerbody;
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
        //CharacterController controller = GetComponent<CharacterController>();
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            /* animation_controller.Play("Base Layer.Walk"); // Add the desired animation  {Format: LayerName.AnimationName} 
             moveDirection = new Vector3(0, 0, -Input.GetAxis("Vertical"));
             moveDirection = transform.TransformDirection(moveDirection);
             moveDirection *= walk_speed - 2.0f;

             moveDirection.y -= gravity * Time.deltaTime;
             controller.Move(moveDirection * Time.deltaTime);

             //Rotate Player.
             if (Input.GetKey("a") || Input.GetKey("d"))
             {
                 transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
             }*/
            playerbody.AddForce(4.0F, 0, 0,ForceMode.Impulse);
        }
    }
}
