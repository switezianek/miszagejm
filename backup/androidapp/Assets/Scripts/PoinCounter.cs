using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PoinCounter : MonoBehaviour
{

    public Text pointText;
    
    private int points = 0;

    // Start is called before the first frame update
    void Start()
    {
     

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            points += 1;
            Destroy(other.gameObject);

		}
	}
    // Update is called once per frame
    void Update()
    {
        pointText.text = "Punkciory: " + points.ToString();   
    }

    public void RetartGame()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
