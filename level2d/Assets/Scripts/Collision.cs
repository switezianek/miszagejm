using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Collision : MonoBehaviour
{
    public GameObject gameOverPanel;
    //public int gameSscore;
    public Vector2 movment;
    public Text endScore;
    public Text gameScore;

    void Start()
    {
      gameOverPanel.gameObject.SetActive(false);  
      Time.timeScale = 1f;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            endScore.text = gameScore.text;
            gameOverPanel.gameObject.SetActive(true);
            Time.timeScale = 0f;
            //Destroy(gameObject);
        }
       // if (other.gameObject.tag == "score")
        //{
        //    gameScore = gameScore+1;
        //    print(gameScore);
         //   movment.x = movment.x +1;
            //gameOverPanel.gameObject.SetActive(true);
          //  Destroy(other.gameObject);
        //}
    }
}