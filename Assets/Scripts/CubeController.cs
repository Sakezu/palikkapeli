using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 8f;   // GD-tyylinen nopeus oikealle
    public float jumpForce = 12f;  // GD-hyppyvoima

    private Rigidbody2D rb;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 3f;  // GD-hyppy ja putoamisnopeus
        rb.interpolation = RigidbodyInterpolation2D.Interpolate;
    }

    void Update()
    {
        // Hyppy 1-tap tyylillä
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        // Automaattinen liike oikealle, GD-tyyli
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Death"))
        {
            Die();
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        isGrounded = false;
    }

    private void Die()
    {
        // Pelaaja kuolee → resetoi alkuun (tai respawn point)
        transform.position = Vector3.zero;
        rb.velocity = Vector2.zero;
    }
}
