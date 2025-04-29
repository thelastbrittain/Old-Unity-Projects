﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float ForwardMovement = 2000f;

    public float SidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,ForwardMovement * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0 ,0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
