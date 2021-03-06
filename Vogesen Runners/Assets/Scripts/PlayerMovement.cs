using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public float jumpForce = 8f;

    public bool isGrounded;
    private bool canJump;

    private Rigidbody2D myRB;

    private float jumpDelay;
    // Start is called before the first frame update
    void Start() {
        myRB = GetComponent<Rigidbody2D> ();
    }

    void Update()
    {
        jumpDelay -= Time.deltaTime;

        if (transform.position.x < -10f || transform.position.y > 5f || transform.position.x > 10f)
        {
            SceneManager.LoadScene("Lobby");
        }

        if (Input.GetKeyDown("space"))
        {
            Jump();
        }
    }


    // Jump Funktion
    public void Jump()
    {
        if (jumpDelay <= 0f)
        {
            myRB.velocity = new Vector2(0f, jumpForce);

            jumpDelay = 1.5f;
        }             
    }

void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag !="Enemy") return;

        SceneManager.LoadScene("Lobby");
    }



    
  







}
