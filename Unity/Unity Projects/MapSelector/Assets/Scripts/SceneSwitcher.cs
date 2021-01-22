using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Great Forest Map");
    }

    public void GotoWastelandScene()
    {
        SceneManager.LoadScene("Wasteland Den");
    }

    public void GotoHollowCaveScene()
    {
        SceneManager.LoadScene("Hollow Cave");
    }

    public void GotoFlowerPatchScene()
    {
        SceneManager.LoadScene("Flower Patch");
    }

    public void GotoLittleBurrowScene()
    {
        SceneManager.LoadScene("Little Burrow");
    }

    public void GotoRaccoonVillageScene()
    {
        SceneManager.LoadScene("Raccoon Village");
    }
}

