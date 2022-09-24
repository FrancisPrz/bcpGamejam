using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    public int digitalMoney;
    public int fisicalMoney;

    private string digitalMoneyPrefsName = "Digital";
    private string fisicalMoneyPrefsName = "Fisical";


    private void Awake()
    {
        LoadData();
    }

    void Start()
    {
        PlayerPrefs.DeleteKey(digitalMoneyPrefsName);
    }

    void Update()
    {
        
    }

    private void OnDestroy()
    {
        SaveData();
    }

    private void SaveData()
    {
        PlayerPrefs.SetInt(digitalMoneyPrefsName, digitalMoney);
        PlayerPrefs.SetInt(fisicalMoneyPrefsName, fisicalMoney);

    }

    private void LoadData()
    {
        digitalMoney = PlayerPrefs.GetInt(digitalMoneyPrefsName, 0);
        fisicalMoney = PlayerPrefs.GetInt(fisicalMoneyPrefsName, 0);
    }
}
