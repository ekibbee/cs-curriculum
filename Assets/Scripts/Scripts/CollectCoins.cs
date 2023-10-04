using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CollectCoins : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            CollectCoin();
        }
    }
    void CollectCoin()
    {
        //gold += 1;
        //Debug.Log(message: "Coins: " +gold);
    }
}
