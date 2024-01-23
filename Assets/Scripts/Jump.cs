using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 10f;
    private Rigidbody rb;
    private bool canJump = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && canJump)
        {
            Jumps();
            canJump = false;
            Invoke("EnableJump", 3.0f); 
        }
    }

    void Jumps()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    void EnableJump()
    {
        canJump = true; 
    }
}
