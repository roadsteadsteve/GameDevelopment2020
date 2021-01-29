using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{

	public int index;
	public string levelName;

	public GameObject MouseGirlRigged;

	void OnTriggerEnter (Collider other)
	{
		StartCoroutine(LoadYourAsyncScene());

		// Scene currentScene = SceneManager.GetActiveScene();

		// if (other.CompareTag ("Player"))
		// 	{
		// 		//Loading Level with Build index
		// 		//SceneManager.LoadScene(index);

		// 		//Loading level with scene name
		// 		SceneManager.LoadScene(levelName);

		// 		SceneManager.MoveGameObjectToScene(MouseGirlRigged, SceneManager.GetSceneByName("Raccoon Village"));
  		// 		SceneManager.UnloadSceneAsync(currentScene);

		// 		//Restart 1v1
		// 		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			
		// 	}

	}


    IEnumerator LoadYourAsyncScene()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Raccoon Village", LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        SceneManager.MoveGameObjectToScene(MouseGirlRigged, SceneManager.GetSceneByName("Raccoon Village"));
        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }

}




