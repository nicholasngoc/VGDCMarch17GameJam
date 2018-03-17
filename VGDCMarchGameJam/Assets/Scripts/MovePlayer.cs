using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public float rotateSpeed;
    public float movementSpeed;

    Rigidbody rb;
    float horizontal;
    float vertical;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update () {
		transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y"), 0, -Input.GetAxis("Mouse X")) * Time.deltaTime * rotateSpeed);
        //transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * rotateSpeed);
    }

    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (Input.GetKey("w"))
        {
            rb.velocity = transform.up * (vertical * movementSpeed);
        }
        if (Input.GetKey("a"))
        {
            rb.velocity = transform.right * (horizontal * movementSpeed);
        }
        if (Input.GetKey("d"))
        {
            rb.velocity = transform.right * (horizontal * movementSpeed);
        }
    }
}
