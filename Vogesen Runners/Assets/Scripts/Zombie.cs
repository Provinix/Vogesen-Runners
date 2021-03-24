using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {

    float dirX;

    [SerializeField]
    float moveSpeed = 9f;

    Rigidbody2D rb;

    bool facingRight = false;

    Vector3 localScale;

    void Start () {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D> ();
        dirX = -1f;

    }    

    void update () {
        if (transform.position.x < -9f)
            dirX = 1f;
        else if (transform.position.x > 9f)
            dirX = -1f;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2 (dirX * moveSpeed, rb.velocity.y);
    }

    void LateUpdate()
    {
      CheckWhereToFace();
    }        

    void CheckWhereToFace()
    {
        if (dirX > 0)
            facingRight = true;

        if (facingRight && localScale.x <0 || !facingRight && localScale.x > 0)
        localScale.x *= -1;

        transform.localScale = localScale;
    }
}

    
