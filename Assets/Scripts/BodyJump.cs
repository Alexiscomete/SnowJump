using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyJump : MonoBehaviour
{
    public Rigidbody2D rb;
    //public Vector3 velocity = Vector3.zero;
    bool isGrounded = true, isJumping = false;
    public int jumpForce;
    public int jumpForceIfHead;
    public HeadJump head;


    public Transform groundCheck;
    public float checkRaduis;
    public LayerMask collisionLayer;

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRaduis, collisionLayer);

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        if (isJumping)
        {
            if (Physics2D.OverlapCircle(head.groundCheck.position, head.checkRaduis, head.collisionLayerBody))
            {
                rb.AddForce(new Vector2(0f, jumpForceIfHead));
            }
            else
            {
                rb.AddForce(new Vector2(0f, jumpForce));
            }
            isJumping = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, checkRaduis);
    }
}
