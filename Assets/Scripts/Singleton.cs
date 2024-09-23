using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null){
            GameObject.Destroy(gameObject);
        }
        else {
            GameObject.DontDestroyOnLoad(gameObject);
            Instance = this;
            //possibly deal with saving here
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
