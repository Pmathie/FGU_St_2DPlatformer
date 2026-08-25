using TMPro;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private int coinCount = 0;
    [SerializeField] private AudioClip coinSound;
    [SerializeField] private TextMeshProUGUI coinText;
    private GameObject[] totalCoins;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        totalCoins = GameObject.FindGameObjectsWithTag("Coin");
        coinText.text = $"Coins collected: {coinCount} / {totalCoins.Length}";

    }

    
    private void AddCoin()
    {
        coinCount++;
        AudioManager.Instance.PlaySound(coinSound);
        coinText.text = $"Coins collected: {coinCount} / {totalCoins.Length}";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            AddCoin();
            Destroy(collision.gameObject);
        }
    }
}
