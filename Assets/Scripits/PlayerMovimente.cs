using UnityEngine;
using System.Security.Cryptography;

public class PlayerMovimente : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 10f;
    private Rigidbody2D rb;
    private float direcao;
    private bool isJumping;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        direcao = Input.GetAxis("Horizontal");
        
        rb.linearVelocity = new Vector2(direcao * speed, rb.linearVelocity.y);
        if (direcao > 0)
        {
            transform.localScale = new Vector2(1f, 1f);
        }
        else if (direcao < 0)
        {
            transform.localScale = new Vector2(-1f, 1f);
        }

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.linearVelocity = jumpForce * Vector2.up;
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            isJumping = false;
        }
    }
}
