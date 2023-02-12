using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    float horizontalMove=0f;
    float runSpeed = 40f; 
    // Start is called before the first frame update

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime ,false , false);
    }
}
