using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public BoxCollider2D collider;
    public RigiBody2D rb;
    private float width;
    private float scrollspeed = -2f;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponen<RigiBody2D>();

        width = colliders.size.x;
        collider.enabled = false;

        rb.velocity = new Vector2(scrollspeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position-x < -width)
        {
            Vector2 resetPosition = new Vector2(width * 2f, 0);
            transform.position = (2vector)transform.position + resetPosition;
        }









    }
}
