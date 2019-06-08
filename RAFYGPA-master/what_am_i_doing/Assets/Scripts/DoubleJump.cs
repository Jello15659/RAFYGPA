using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    public int jumps = 0;
    public Transform groundCheck;
    public float groundedRadius;
    public LayerMask whatIsGround;
    void FixedUpdate()
    {
        if (Physics2D.OverlapCircle(groundCheck.position, groundedRadius, whatIsGround))
        {
            jumps = 0;
        }
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump") && jumps < 2)
        {
            //Jump code here.
            jumps += 1;
        }
    }
}
