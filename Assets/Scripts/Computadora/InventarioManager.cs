using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventarioManager : MonoBehaviour
{
    #region variables

    [Header("Cantidades")]
    public int cantVitrina1;
    public int cantVitrina2;
    public int cantVitrina3;

    [Header("Cantidades Textos")]
    public TMP_Text text_cantVitrina1;
    public TMP_Text text_cantVitrina2;
    public TMP_Text text_cantVitrina3;
    
    [Header("Precios de relleno")]
    public TMP_Text text_buttonVitrina1;
    public TMP_Text text_buttonVitrina2;
    public TMP_Text text_buttonVitrina3;

    #endregion

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
