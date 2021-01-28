using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public Rigidbody rigidBody;


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
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            // nove right
            rigidBody.AddForce( Vector3.right * movementForce); // Vector3.right (1.0f, 0.0f, 0.0f)
        }   

        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            //move left
            rigidBody.AddForce(Vector3.left * movementForce);
        }
    }
}
