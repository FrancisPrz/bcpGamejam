using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MejorasButton : MonoBehaviour
{
    public MejorasManager mejorasManager;

    public void ButtonMejoras()
    {
        if(mejorasManager.flechaPersonal.enabled)
        {
            if (mejorasManager.nivelPersonal < 3)
            {
                mejorasManager.nivelPersonal += 1;
            }
        }

        if (mejorasManager.flechaMesas.enabled)
        {
            if (mejorasManager.nivelMesas < 3)
            {
                mejorasManager.nivelMesas += 1;
            }
        }

        if (mejorasManager.flechaVitrinas.enabled)
        {
            if (mejorasManager.nivelVitrinas < 3)
            {
                mejorasManager.nivelVitrinas += 1;
            }
        }

        if (mejorasManager.flechaDelivery.enabled)
        {
            if (mejorasManager.nivelDelivery < 3)
            {
                mejorasManager.nivelDelivery += 1;
            }
        }

    }
}
