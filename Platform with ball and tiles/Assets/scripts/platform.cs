using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate() {
        Motion();
    }
    private void Motion() {

        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y); 
    }
    private void Rotation() {
        ;
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "horizontalBorder") {
            rb.velocity = new Vector2(-rb.velocity.x, -rb.velocity.y);
        }
    }
}
