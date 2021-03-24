using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public float jumpForce = 5f;

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
        Debug.Log("Blablabla");
        //SceneManager.LoadScene("Lobby");
    }


        
}
