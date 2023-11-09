using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyperEngine : MonoBehaviour
{
    public Rigidbody rb;
    public float moveForce;
    public float turnTorque;
   public Vector3 gravity = new Vector3(0, 1, 0);
    public Vector3 rot = new Vector3(0, 1, 0);
    public float gMoon = 1.6f;  //gravity on the moon.
    private void Update()
    {
        
        //rb.AddForce(Input.GetAxis("Vertical") * moveForce * gravity);
        
        //rb.AddTorque(Input.GetAxis("Horizontal") * turnTorque * rot);
    }
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(0, -1.0f, 0) * rb.mass * gMoon);
    }
}
