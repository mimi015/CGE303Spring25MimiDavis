using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//add this to work with scene manager to load or reload scenes
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    //public static variables
    //notice public static variables
    //can be accessesed from any script
    //but cannot be seen in the Inspector
    public static bool gameOver;
    public static bool won;
    public static int score;

    //reference to our textbox
    //this needs to be set in the inspector
    public TMP_Text textbox;
    public int scoreToWin;
    

    // Start is called before the first frame update
    void Start()
    {
        //set the initial values for variables
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver) 
        {
            textbox.text = "Score: " + score;
        }

        if (score >= scoreToWin)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You win! \nPress R to Try Again";
            }
            else
            {
                textbox.text = "You lose! \nPress R to Try Again";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
