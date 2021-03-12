using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public int scene;

    bool loaded;

    void OnTriggerEnter ()
    {
    	if (!loaded)
    	{
    		SceneManager.LoadSceneAsync (scene, LoadSceneMode.Additive);

    		loaded = true;
    	}
    }
}
