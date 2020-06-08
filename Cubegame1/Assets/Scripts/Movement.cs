using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sideForce = 500f;

    // Update is called once per frame
    // "Fixed"Update for Physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);// forward Force
        if (Input.GetKey("d"))
        {
        rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //Force to the right
        }

        if (Input.GetKey("a"))
        {
        rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);//Force to the left
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<Gamemanager>().EndGame();
        }
    }

    

}
