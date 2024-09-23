using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance;

    void Start()
    {
        if (Instance != null){
            GameObject.Destroy(gameObject);
        }
        else {
            GameObject.DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
}
