using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
public TextMeshProUGUI coinText;
    private float coin = 0;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Coin"){
            coin ++;
            coinText.SetText(coin.ToString() + " x");
            Destroy(other.gameObject);
        }
    }
}
