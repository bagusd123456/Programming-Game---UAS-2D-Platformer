using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    bool gameOver = false;
    public float restartDelay = 1f;
    public GameObject winUI;
    public GameObject loseUI;

    public PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
    }

    public void LevelFinished()
    {
        winUI.SetActive(true);
        
    }

    public void GameOver()
    {
        if(player.gameOver == true)
        {
            loseUI.SetActive(true);
            player.movementSpeed = 0f;
            player.jumpForce = 0f;
            player.dashSpeed = 0f;

            //Debug.Log("Game Over");
            //Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level 2");
    }
}
