using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataScore : MonoBehaviour
{
    public static int Score ;
    public GameObject[] coin;
    public TMP_Text Scoretext;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        coin = GameObject.FindGameObjectsWithTag("Coin");
    }

    // Update is called once per frame
    void Update()
    {
        string value = Score.ToString("000");
        Scoretext.text = "Coins     : " + value;
    }
}
