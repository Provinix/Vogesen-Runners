using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public float jumpForce = 8f;

    private Rigidbody2D myRB;
    // Start is called before the first frame update
    void Start() {
        myRB = GetComponent<Rigidbody2D> ();
    }

    // Jump Funktion
    public void Jump()
    {
        myRB.velocity = new Vector2(0f, jumpForce);
    }

void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag !="Enemy") return;

        SceneManager.LoadScene("Lobby");
    }

/*void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag !="Enemy") return;

        SceneManager.LoadScene("Lobby");
    }*/

    void Update(){
        if(transform.position.x <-10f || transform.position.y >5f || transform.position.x >10f){
            SceneManager.LoadScene("Lobby");
        }
    }
}
