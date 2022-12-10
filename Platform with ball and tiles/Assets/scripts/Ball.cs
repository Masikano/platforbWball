using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(rb.velocity.x, -speed);
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    private void FixedUpdate() {
        
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "platform")
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
        if (collision.gameObject.GetComponent<Tile>())
        {
            rb.velocity = new Vector2(rb.velocity.x, -speed);
            Destroy(collision.gameObject, .1f);
        }
        if (collision.gameObject.name == "top border")
        {
            rb.velocity = new Vector2(rb.velocity.x, -speed);
        }
        if (collision.gameObject.name == "bot border")
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (collision.gameObject.name == "right border")
        {
            rb.AddForce(transform.right, ForceMode2D.Impulse);
            // rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
        }
        if (collision.gameObject.name == "left border")
        {
            rb.AddForce(transform.right, ForceMode2D.Impulse);
            //rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);
        }
    }
}
