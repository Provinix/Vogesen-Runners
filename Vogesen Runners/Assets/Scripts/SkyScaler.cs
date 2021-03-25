using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyScaler : MonoBehaviour {
    // Start is called before the first frame update
   
    void Start()
    {
        // Höhe berechnen
        float height = Camera.main.orthographicSize * 2f;
        // Breite berechnen
        float width = height * Screen.width / Screen.height * 2;

        if (gameObject.name == "Sky") {
            //GameObject (Background) skalieren
            transform.localScale = new Vector3 (width, height, 0);
        } else
            transform.localScale = new Vector3 (width, 2, 0);      
    }

    // Update is called once per frame
    void Update() {
    
    }
}
