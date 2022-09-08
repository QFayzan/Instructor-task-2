using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    
   
    public TextMeshProUGUI gameOverText;       //puts public field for canvas value
    public TextMeshProUGUI restartInstructions;       //puts public field for canvas value
    public bool gameOver = false;          //Will be used for game over and restart
                                           //Health system 
    

    // Start is called before the first frame update
    void Start()
    {
        //Disable panels on restart
       // Time.timeScale = 1;
        //gameOverText.gameObject.SetActive(false);
        //restartInstructions.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
      //  restartInstructions.text = "Press R to Restart ";
     //   gameOverText.text = " Game Over";
        // Never let health go negative
        
       
       // if (gameOver == true)
        //{
        //    GameOver();   
        //}
    }
    //void GameOver()
    //{
      //  Time.timeScale = 0;
        //gameOverText.gameObject.SetActive(true);
        //restartInstructions.gameObject.SetActive(true);
        //If R is hit, restart the current scene
        //if (Input.GetKeyDown(KeyCode.R))
          //  {
            //SceneManager.LoadScene("Main1");

       // }
    //}
}
