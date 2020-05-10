using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
   //variables
    public CharacterController controller;
    public float speed = 4f;
    public Vector3 move;
    public Vector3 velocity;
    public float gravity = -19.81f;
    public bool isGrounded = false;
    public float JumpHeight = 100f;
    public Rigidbody rb;

    // Update is called once per frame

    


    void Update()
    {
        if (isGrounded==true)
        {
            velocity.y = -2f;

        }
       /* if (Input.GetButtonDown("Jump")&& isGrounded==true)
        {

            isGrounded = false;
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * gravity);

        } */

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        
  
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        
    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
       
    }
}
