using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    public float speed = 10;

    bool facingRight = true;

    public bool grounded = false;
    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    Rigidbody2D rig;
    // Use this for initialization
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        float move;
        move = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(move * speed, rig.velocity.y);

        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            rig.AddForce(new Vector2(0, 200f));
        }

        if ((move < 0) && facingRight)
            Flip();
        else if ((move > 0) && !facingRight)
            Flip();
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void OnTriggerEnter2D(Collider2D shit)
    {
        if (shit.gameObject.tag == "Fin 1")
        {
            SceneManager.LoadScene("Scene 2");
        }
        {
            if (shit.gameObject.tag == "Fin 2")
            {
                SceneManager.LoadScene("Scene 3");
            }
            {
                if (shit.gameObject.tag == "Respawn")
                {
                    SceneManager.LoadScene("Scene 2");
                }
                {
                    if (shit.gameObject.tag == "Fin 3")
                    {
                        SceneManager.LoadScene("Scene 4");
                    }

                }

            }

        }

    }


}
