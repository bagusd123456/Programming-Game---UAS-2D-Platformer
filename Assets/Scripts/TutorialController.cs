using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialController : MonoBehaviour
{
    public GameObject tutorialPanel;
    public TMP_Text tutorialText;
    public Transform tutorialPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.name.Equals("Tutorial 1"))
        {
            tutorialPanel.SetActive(true);
            tutorialText.text = "Tekan key 'A' atau 'D' untuk bergerak ke kiri atau kekanan.";
            //Debug.Log("Tutorial 1");
        }
        else if (gameObject.name.Equals("Tutorial 2"))
        {
            tutorialPanel.SetActive(true);
            tutorialText.text = "Kumpulkan Coin untuk membeli perlengkapan baru.";
        }
        else if (gameObject.name.Equals("Tutorial 3"))
        {
            tutorialPanel.SetActive(true);
            tutorialText.text = "Tekan key 'Space' untuk melompat hingga 2 kali.";
        }

        else if (gameObject.name.Equals("Tutorial 4"))
        {
            tutorialPanel.SetActive(true);
            tutorialText.text = "Tekan 'Space' dan arah untuk melakukan wall Jump.";
        }

        else if (gameObject.name.Equals("Tutorial 5"))
        {
            tutorialPanel.SetActive(true);
            tutorialText.text = "Tekan dan tahan key 'Space' untuk lompat lebih tinggi.";
        }

        else if (gameObject.name.Equals("Tutorial 6"))
        {
            tutorialPanel.SetActive(true);
            tutorialText.text = "Tekan 'Left Shift' saat di udara tanpa menekan 'key bergerak' untuk melakukan Dash.";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        tutorialPanel.SetActive(false);
    }
}
