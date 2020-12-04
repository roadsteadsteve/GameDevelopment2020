using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBoyInput : MonoBehaviour
{

	private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    	animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hello world");
    	animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
    	animator.SetFloat("Vertical", Input.GetAxis("Vertical"));

    }
}
