using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputadoraManager : MonoBehaviour
{
    public GameObject computadoraPanel, inventarioPanel, mejorasPanel, finanzasPanel;


    void Start()
    {
        //computadoraPanel.SetActive(false);
        inventarioPanel.SetActive(false);
        mejorasPanel.SetActive(false);
        finanzasPanel.SetActive(false);
    }
    
    public void CloseComputadora()
    {
        computadoraPanel.SetActive(false);
    }
    public void OpenInventario()
    {
        inventarioPanel.SetActive(true);
        mejorasPanel.SetActive(false);
        finanzasPanel.SetActive(false);
    }

    public void OpenMejoras()
    {
        inventarioPanel.SetActive(false);
        mejorasPanel.SetActive(true);
        finanzasPanel.SetActive(false);
    }
    public void OpenFinanzas()
    {
        inventarioPanel.SetActive(false);
        mejorasPanel.SetActive(false);
        finanzasPanel.SetActive(true);
    }

}
