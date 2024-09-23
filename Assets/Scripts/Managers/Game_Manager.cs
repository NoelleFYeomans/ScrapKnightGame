using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    //references to managers within unity
    public GameObject LevelManager;
    public GameObject UIManager;
    public GameObject SaveManager;
    
    //objects where references managers are stored
    private Level_Manager _levelManager;
    private UI_Manager _uiManager;
    private Save_Manager _saveManager;

    //gamestate enum
    public enum CurrentGameScene{
        TitleScene,
        GameScene,
        ShopScene
        //add more as needed

    }

    private CurrentGameScene _currentGameScene;
    
    void Start()
    {
        _levelManager = LevelManager.GetComponent<Level_Manager>();
        _uiManager = UIManager.GetComponent<UI_Manager>();
        _saveManager = SaveManager.GetComponent<Save_Manager>();

        //loads saved data
        _saveManager.loadData();

        //other stuff here
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //bring up options menu
        }
    }
}
