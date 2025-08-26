using UnityEngine;
using System.Security.Cryptography;
using UnityEngine.SceneManagement;

public class PlayerMovimente : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 10f;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private float direcao;
    private bool isJumping;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        direcao = Input.GetAxis("Horizontal");
        
        rb.linearVelocity = new Vector2(direcao * speed, rb.linearVelocity.y);
        if (direcao > 0)
        {
            //transform.localScale = new Vector2(1f, 1f);
            sr.flipX = false;
        }
        else if (direcao < 0)
        {
            //transform.localScale = new Vector2(-1f, 1f);
            sr.flipX = true;
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trofel"))
        {
            SceneManager.LoadScene("Vitoria");
        }
    }
}
