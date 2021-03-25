using UnityEngine;

public class CoinPicker : MonoBehaviour
{

    private float coin = 0;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Coin"){
            coin ++;
            Destroy(other.gameObject);
        }
    }
}
