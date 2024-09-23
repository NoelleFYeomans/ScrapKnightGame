using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int returnSceneIndex(){ //returns the number associated w/ current scene
        return SceneManager.GetActiveScene().buildIndex;
    }

    public void loadTitleScene(){
        SceneManager.LoadScene(0); //scene 0 is the titlescreen
    }


public void quitGame(){
    Application.Quit();
    Debug.Log("game has been quit");
}
}
