using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unload : MonoBehaviour
{
    public int scene;

    bool unloaded;

    void OnTriggerEnter ()
    {
    	if (!unloaded)
    	{
    		unloaded = true;

    		AnyManager.anyManager.UnloadScene(scene);
    	}
    }
}
