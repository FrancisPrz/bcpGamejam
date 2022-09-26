using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    public int digitalMoney;
    public int phisicalMoney;

    private string digitalMoneyPrefsName = "Digital";
    private string phisicalMoneyPrefsName = "Phisical";


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
        PlayerPrefs.SetInt(phisicalMoneyPrefsName, phisicalMoney);

    }

    private void LoadData()
    {
        digitalMoney = PlayerPrefs.GetInt(digitalMoneyPrefsName, 0);
        phisicalMoney = PlayerPrefs.GetInt(phisicalMoneyPrefsName, 0);
    }
}
