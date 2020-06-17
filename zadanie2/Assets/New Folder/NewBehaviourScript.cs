using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float playerSpeed =0;
	private Vector2 movment;
    public float jumpForce = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
    
	movment.x = Input.GetAxisRaw("Horizontal");
	movment.y = Input.GetAxisRaw("Vertical");
	//print (movment.y);
    print (movment.x);
        transform.position += new Vector3(playerSpeed * movment.x*Time.deltaTime, playerSpeed * movment.y*Time.deltaTime, 0);
        //input
    }

    void FixedUpdate(){
     //fizyka
     rb.velocity = new Vector2(movment.x*playerSpeed,rb.velocity.y);
     rb.AddFroce(Vector2.up * jumpForce);
	}

 
   }