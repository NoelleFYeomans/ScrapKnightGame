using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
using UnityEditor.Experimental.RestService;

public class Save_Manager : MonoBehaviour
{
    public static Save_Manager Instance;

    //define savable information below
    public int attemptCount;
    //there will be more

    public int armorUpgradeStage = 0, swordUpgradeStage = 0, maxEnergyUpgradeStage = 0, energyEfficiencyUpgradeStage = 0, healthUpgradeStage = 0, collectableUpgradeStage = 0, playerSpeedUpgradeStage = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null){
            Instance = this;
        }
        else{
            // Handle duplicate instances, or take appropriate action.
            Destroy(this.gameObject);
        }
    }

    public void saveData() //PlayerData saving method
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat"); //creates save
        PlayerData data = new PlayerData();

        //apply current info to existing data IE: data.armorUpgradeStage = armorUpgradeStage

        bf.Serialize(file, data);
        file.Close();
    }

    public void loadData() //PlayerData loading method
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            //apply saved data to default data IE: armorUpgradeStage = data.armourUpgradeStage

        }
    }

    public void clearData() //Calling this method deletes saved data
    {
        Debug.Log("Data Clear Method Called");
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            File.Delete(Application.persistentDataPath + "/playerInfo.dat"); //this deletes the save file
            Debug.Log("Data Has Been Cleared");
        }
    }

    //class exists to serialize player's progression data
    [Serializable]
    class PlayerData
    {
        //fill eventually
    }
}
