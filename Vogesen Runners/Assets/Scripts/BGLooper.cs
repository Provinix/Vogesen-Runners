using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class BGLooper : MonoBehaviour {

    public float speed = 0.05f;

    private Material mat;
    private Vector2 offset = Vector2.zero;


    // Start is called before the first frame update
    void Start () {
        mat = GetComponent<Renderer> ().material;
        offset = mat.GetTextureOffset("_MainTex");
        
    }

    // Update is called once per frame
    void Update ()
    {
        offset.x = offset.x + speed * Time.deltaTime;
        mat.SetTextureOffset("_MainTex", offset);
    }

    
}
