using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    [SerializeField] int CoinAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var Coin = collision.GetComponent<PlayerEntitiy>(); // var�� c++ auto�� ���
            //var Score = collision.GetComponent<Score>();
            Coin.OnCoinUpdated(CoinAmount);

            

            Destroy(gameObject);
        }
    }
}
