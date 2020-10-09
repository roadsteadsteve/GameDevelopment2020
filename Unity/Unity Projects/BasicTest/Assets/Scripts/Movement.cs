using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	[SerializeField]
	private float _speed;

	[SerializeField]
	private float _horizontalInput;

	[SerializeField]
	private float _verticalInput;

	[SerializeField]
	private float _jumpInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	_horizontalInput = Input.GetAxis("Horizontal");
    	transform.Translate(new Vector3(_horizontalInput, 0, 0) * _speed * Time.deltaTime);

    	_verticalInput = Input.GetAxis("Vertical");
    	transform.Translate(new Vector3(0, 0, _verticalInput) * _speed * Time.deltaTime);

    	_jumpInput = Input.GetAxis("Jump");
    	transform.Translate(new Vector3(0, _jumpInput, 0) * _speed * Time.deltaTime);
        
    }
}

