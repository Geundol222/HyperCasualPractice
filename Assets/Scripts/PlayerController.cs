using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpSpeed;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Jump()
    {
        // rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        rb.velocity = Vector2.up * jumpSpeed;
    }

    private void OnJump(InputValue value)
    {
        Jump();
    }
}
