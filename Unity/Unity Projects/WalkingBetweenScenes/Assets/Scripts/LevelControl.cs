using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{

	public int index;
	public string levelName;

	void OnTriggerEnter (Collider other)
	{
		if (other.CompareTag ("Player"))
			{
				//Loading Level with Build index
				//SceneManager.LoadScene(index);

				//Loading level with scene name
				SceneManager.LoadScene(levelName);

				//Restart 1v1
				//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}

	
	
		}



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}




