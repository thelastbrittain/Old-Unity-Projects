using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlledForce : MonoBehaviour
{
    public Vector3 v3Force;

    public KeyCode PositiveKey;

    public KeyCode NegativeKey;

    void FixedUpdate()
    {
        if (Input.GetKey(PositiveKey))
        {
            GetComponent<Rigidbody>().velocity += v3Force;
        }

        if (Input.GetKey(NegativeKey))
        {
            GetComponent<Rigidbody>().velocity -= v3Force;
        }
    }
}
