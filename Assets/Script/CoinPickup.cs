using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    // Start is called before the first frame update
    public int value;
    public int soundToPlay;

    public GameObject coinsEffect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other) {
         if(other.tag == "Player"){
            GameManager.instance.AddCoins(value);
            Destroy(gameObject);
            Instantiate(coinsEffect, transform.position, transform.rotation);
            AudioManager.instance.PlaySFX(5);
        }
    }
}
