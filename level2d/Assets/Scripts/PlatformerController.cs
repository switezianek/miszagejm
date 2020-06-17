using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlatformerController : MonoBehaviour
{
    public float movementSpeed = 1f;
    public float jumpForce = 5f;
    public Text pointText;

    private Rigidbody2D rb;
    private SpriteRenderer m_SpriteRenderer;
    public Vector2 movment;
    private bool isJump = false;
    private bool ground = false;
    public int gameScore;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Fetch the SpriteRenderer from the GameObject
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        movment.x = 1;
    }

    // Update is called once per frame
    void Update()
    {
    isJump = ground;
    pointText.text = "Cacatuses: " + gameScore.ToString();
        //isJump = Input.GetButtonDown("Jump") && ground;
        //if (isJump)
       // {
           // rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
           // ground = false;
       // }
    }
    public void jumpaction()
    {
        if (isJump)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            ground = false;
        }
	}

    void FixedUpdate()
    {
        //get the Input from Horizontal axis
        //movment.x = 1;
        //get the Input from Vertical axis
        movment.y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(movment.x * movementSpeed, rb.velocity.y);


    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "ground")
        {
            ground = true;
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "score")
        {
            gameScore = gameScore+1;
            print(gameScore);
            movementSpeed = movementSpeed+0.5f;
            //gameOverPanel.gameObject.SetActive(true);
           // Destroy(other.gameObject);
        }
    }
    public void RestartGame()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}


}