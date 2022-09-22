using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public Wallet wallet;

    public void GainMoney()
    {
        wallet.digitalMoney += Random.Range(0, 10);
    }

    public void WasteMoney()
    {
        wallet.digitalMoney -= Random.Range(0, 10);
    }

    public void HowMuchMoney()
    {
        Debug.Log("Tienes " + wallet.digitalMoney + "$ en tu cuenta.");
    }
}
