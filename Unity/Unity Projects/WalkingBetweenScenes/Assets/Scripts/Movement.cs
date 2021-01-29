using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	private Rigidbody rb;
	private float moveSpeed;
	private float dirX, dirZ;

    // Start is called before the first frame update
    private void Start()
    {
        moveSpeed = 3f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        dirZ = Input.GetAxis("Vertical") * moveSpeed;

        if (Input.GetKeyDown (KeyCode.Space)) {
    		  transform.Translate(Vector3.up * Time.deltaTime*100);
       	}
    		
   	    if (Input.GetKeyUp (KeyCode.Space)) {
  			//transform.position=initialposition;
      		transform.Translate(Vector3.down * Time.deltaTime*100);
       		Debug.Log("Clicked");
    	}
   		
   		Debug.Log(transform.position);
    }

    private void FixedUpdate() 
    {
    	rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }
}
