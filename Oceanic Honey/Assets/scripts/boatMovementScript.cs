using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatMovementScript : MonoBehaviour {
    // rigid body
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        // get the rigid body
        rb = GetComponent<Rigidbody2D>();

        // the current
        Vector2 current = new Vector2(-6, 0);
        rb.AddForce(current, ForceMode2D.Force);
    }

}
