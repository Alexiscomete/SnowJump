using UnityEngine;

public class HeadJump : MonoBehaviour
{

    public Rigidbody2D rb;
    //public Vector3 velocity = Vector3.zero;
    bool isGrounded = true, isJumping = false;
    public int jumpForce;

    public Transform groundCheck;
    public float checkRaduis;
    public LayerMask collisionLayer;
    public LayerMask collisionLayerBody;

    void Update()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRaduis, collisionLayer) || Physics2D.OverlapCircle(groundCheck.position, checkRaduis, collisionLayerBody);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        if (isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, checkRaduis);
    }
    
}
