using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    void FixedUpdate()
    {
        Vector3 force = new Vector3();
        if (Input.GetKey(KeyCode.A))       force.x = 1000;
        else if (Input.GetKey(KeyCode.D))  force.x = -1000;
        if (Input.GetKey(KeyCode.S))       force.y = -1000;
        else if (Input.GetKey(KeyCode.W))  force.y = 1000;
        rb.AddForce(force * Time.deltaTime);
    }
}
