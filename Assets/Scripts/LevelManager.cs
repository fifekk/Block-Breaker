using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
       public void LoadLevel(string name)
    {
        Debug.Log("Load level requested: " + name);
        
        SceneManager.LoadScene(name);
        
    }
    public void QuitRequest()
    {
        Debug.Log("Quit was requested " + name);
        Application.Quit();
    }
    public void LoadNextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }
    public void BrickDestryed()
    {
        if (Brick.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }
}
