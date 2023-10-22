using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask platformLayerMask;
    private CapsuleCollider2D CapsuleCollider2D;
    private Rigidbody2D rb;
    public float moveSpeed = 3.0f;
    public float jumpForce = 400.0f;

    private void Awake()
    {
        CapsuleCollider2D = GetComponent<CapsuleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 moveDirection = new Vector2(horizontalInput, 0);
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, rb.velocity.y);

        if (IsGrounded() && Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, jumpForce));
        }
    }

    public bool IsGrounded()
    {
        float extraHeight = .1f;
        RaycastHit2D raycastHit = Physics2D.Raycast(CapsuleCollider2D.bounds.center, Vector2.down, CapsuleCollider2D.bounds.extents.y + extraHeight, platformLayerMask);
        return raycastHit.collider != null;
    }
}







