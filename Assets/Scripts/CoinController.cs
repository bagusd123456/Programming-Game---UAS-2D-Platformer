using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{

    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DataScore.Score += 1;
            Destroy(this.gameObject);
        }

        /*foreach (GameObject obj in data.coin)
        {
            if (collision.CompareTag("Player"))
            {
                data.Score++;
                Destroy(this.gameObject);
            }
        }*/
    }
}
