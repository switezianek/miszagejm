using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

	public float playerSpeed =0;
	private Vector2 movment;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	movment.x = Input.GetAxisRaw("Horizontal");
	movment.y = Input.GetAxisRaw("Vertical");
	//print (movment.y);
    print (movment.x);
        transform.position += new Vector3(playerSpeed * movment.x*Time.deltaTime, playerSpeed * movment.y*Time.deltaTime, 0);
        //if (movment.x <0){
        //    m_SpriteRenderer.flipX = false;  
		//}
        //else if (movment.x >0){
         //   m.SpriteRenderer.flipX = true  
		//}
    }
}
