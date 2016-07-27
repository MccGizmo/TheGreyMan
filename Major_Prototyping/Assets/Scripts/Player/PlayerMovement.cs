﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;

    Vector3 movement;
    Animator anim;
    Rigidbody playerRigidbody;
    int floorMask;
    float camRayLength = 100f;

    void Awake()
    {
        floorMask = LayerMask.GetMask("Floor");
        //anim = GetComponent<Animator> ();
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw ("Horizontal");
        float v = Input.GetAxisRaw ("Vertical");

        Move(h, v);
        Turning();
        //Link to bottom
        //Animating(h, v);
    }

    void Move(float h, float v)
    {
        movement.Set(h, 0f, v);

        // This is so the diagonal movement for the player character is the same speed as the up and down movement
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }

    void Turning()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit floorHit;

        if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
        {
            Vector3 playerToMouse = floorHit.point - transform.position;
            playerToMouse.y = 0f;

            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            playerRigidbody.MoveRotation (newRotation);
        }
    }

    /* For Later on when we add animations and shit
    void Animating(float h, float v)
    {
        // If the horizontal or vertical axis keys are pressed, start the walking animation
        bool walking = h != 0f || v != 0f;
        anim.SetBool("IsWalking", walking);
    }
    */
}
