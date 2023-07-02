using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public GameObject ball;

    string settingsLocation;
    string jsonVehicle;

    public Settings _Settings = new Settings();
    

    void Start()
    {
        Instantiate(ball);

        settingsLocation = Application.persistentDataPath+"/SettingsData.json";
    
        if (System.IO.File.Exists(settingsLocation))
        {
            Loader();
        }
        else
        {
            Debug.LogError("settings not found at " + settingsLocation);
            jsonVehicle = JsonUtility.ToJson(_Settings);
            System.IO.File.WriteAllText (settingsLocation, jsonVehicle);
            Debug.Log("Settings applied");
        }
    }
    public void Loader()
    {
        jsonVehicle = File.ReadAllText(settingsLocation);
        _Settings = JsonUtility.FromJson<Settings>(jsonVehicle);
    }
}
