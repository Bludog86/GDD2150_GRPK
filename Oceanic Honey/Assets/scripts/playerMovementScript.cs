using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    // rigid body
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        // get the rigid body
        rb = GetComponent<Rigidbody2D>();

        // the current
        Vector2 current = new Vector2(-12, 0);
        rb.AddForce(current, ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update()
    {
        // movement script was borrowed from the Unity Documentation
        float horizontalSpeed = .2f;
        float verticalSpeed = .2f;

        // get the swim foward/backward key
        if (Input.GetButtonDown("Horizontal"))
        {
            horizontalSpeed *= Input.GetAxisRaw("Horizontal");
            transform.Translate(horizontalSpeed, 0, 0);
        }

        // get the swim up/down
        if (Input.GetButtonDown("Vertical"))
        {
            verticalSpeed *= Input.GetAxisRaw("Vertical");
            transform.Translate(0, verticalSpeed, 0);
        }
    }
}

