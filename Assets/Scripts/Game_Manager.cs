using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public GameObject LevelManager;
    public GameObject UIManager;
    public GameObject SaveManager;
    
    private Level_Manager _levelManager;
    private UI_Manager _uiManager;
    private Save_Manager _saveManager;

    public enum CurrentGameScene{
        TitleScene,
        GameScene,
        ShopScene,
        //add more as needed

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
