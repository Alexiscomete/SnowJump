using UnityEngine;

public class BodyJump : MonoBehaviour
{
    public Rigidbody2D rb;
    //public Vector3 velocity = Vector3.zero;
    public bool isGrounded = true, isJumping = false, isHeadJumping = false;
    public int jumpForce;
    public int jumpForceIfHead;
    public HeadJump head;


    public Transform groundCheck;
    public float checkRaduis;
    public LayerMask collisionLayer;

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRaduis, collisionLayer);

        if (Input.GetButtonDown("Jump"))
        {
            isHeadJumping = true;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        if (isJumping)
        {
            if (Physics2D.OverlapCircle(head.groundCheck.position, head.checkRaduis, head.collisionLayerBody) && !isHeadJumping)
            {
                rb.AddForce(new Vector2(0f, jumpForceIfHead));
            }
            else
            {
                rb.AddForce(new Vector2(0f, jumpForce));
            }
            isJumping = false;
        }
        isHeadJumping = false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, checkRaduis);
    }
}
