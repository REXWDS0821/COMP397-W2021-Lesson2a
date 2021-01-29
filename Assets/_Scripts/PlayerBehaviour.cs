using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public Rigidbody rigidBody;
    public bool isGrounded;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame - once every 16.666ms
    // 1000ms for each second
    // approximately updates 60 times per second + 60fps
    // fps = frame per seconds

    void Update()
    {
        if (isGrounded)
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                // nove right
                rigidBody.AddForce(Vector3.right * movementForce); // Vector3.right (1.0f, 0.0f, 0.0f)
            }

            if (Input.GetAxisRaw("Horizontal") < 0)
            {
                //move left
                rigidBody.AddForce(Vector3.left * movementForce);
            }

            if (Input.GetAxisRaw("Vertical") > 0)
            {
                // nove forward
                rigidBody.AddForce(Vector3.forward * movementForce); // Vector3.right (1.0f, 0.0f, 0.0f)
            }

            if (Input.GetAxisRaw("Vertical") < 0)
            {
                //move back
                rigidBody.AddForce(Vector3.back * movementForce);
            }

            if(Input.GetAxisRaw("Jump") > 0)
            {
                //Jump
                rigidBody.AddForce(Vector3.up * jumpForce);
            }
        }
    }

     void OnCollisionEnter(Collision other)
     {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        
     }

    void OnCollisionStay(Collision other)
     {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

     void OnCollisionExit(Collision other)
     {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }


}
