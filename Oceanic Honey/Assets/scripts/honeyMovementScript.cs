using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class honeyMovementScript : MonoBehaviour {

    // rigid body
    Rigidbody2D rb;

    // Use this for initialization
    void Start ()
    {
        // get the rigid body
        rb = GetComponent<Rigidbody2D>();
	}

    // fixed update
    private void FixedUpdate()
    {
        Vector2 current = new Vector2(.05f, 0);
        rb.AddForce(current,ForceMode2D.Force);
    }
}
