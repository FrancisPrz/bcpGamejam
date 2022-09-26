using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MejorasManager : MonoBehaviour
{
    #region Variables
    [Header("Títulos e Información")]
    public TMP_Text infoPanel_Text;
    public TMP_Text infoTitle_Text;

    [Header("Texto Botones Mejora")]
    public TMP_Text mejorasButton;

    [Header("Flechas de Selección")]
    public Image flechaPersonal;
    public Image flechaMesas;
    public Image flechaVitrinas;
    public Image flechaDelivery;

    [Header("Otros")]
    public Image IMG_General;

    [Header("Bolitas Personal")]
    public Image IMG_BolitaPersonal_Lvl1;
    public Image IMG_BolitaPersonal_Lvl2;
    public Image IMG_BolitaPersonal_Lvl3;

    [Header("Bolitas Mesas")]
    public Image IMG_BolitaMesas_Lvl1;
    public Image IMG_BolitaMesas_Lvl2;
    public Image IMG_BolitaMesas_Lvl3;

    [Header("Bolitas Vitrinas")]
    public Image IMG_BolitaVitrinas_Lvl1;
    public Image IMG_BolitaVitrinas_Lvl2;
    public Image IMG_BolitaVitrinas_Lvl3;

    [Header("Bolitas Delivery")]
    public Image IMG_BolitaDelivery_Lvl1;
    public Image IMG_BolitaDelivery_Lvl2;
    public Image IMG_BolitaDelivery_Lvl3;

    public int nivelPersonal, nivelMesas, nivelVitrinas, nivelDelivery;

    [Header("Practica")]
    public int platosComida;


    #endregion

    void Start()
    {
        flechaPersonal.enabled = true;
        flechaMesas.enabled = false;
        flechaVitrinas.enabled = false;
        flechaDelivery.enabled = false;

        nivelPersonal = 1;
        nivelMesas = 1;
        nivelVitrinas = 1;
        nivelDelivery = 1;

        InfoMejorarPersonal();
        InfoMejorarMesas();
        InfoMejorarVitrinas();
        InfoMejorarDelivery();
    }

    public void Update()
    {
        if(flechaPersonal.enabled)
        {
            InfoMejorarPersonal();
        }

        if(flechaMesas.enabled)
        {
            InfoMejorarMesas();
        }

        if (flechaVitrinas.enabled)
        {
            InfoMejorarVitrinas();
        }

        if (flechaDelivery.enabled)
        {
            InfoMejorarDelivery();
        }

    }

    public void MejorarPersonal()
    {
        flechaPersonal.enabled = true;
        flechaMesas.enabled = false;
        flechaVitrinas.enabled = false;
        flechaDelivery.enabled = false;
    }
    public void InfoMejorarPersonal()
    {
        if (nivelPersonal == 1)
        {
            infoTitle_Text.text = "Siguiente Nivel";
            infoPanel_Text.text = "Contrata a un personal";

            IMG_General.sprite = Resources.Load<Sprite>("Sprites/2");

            IMG_BolitaPersonal_Lvl1.enabled = true;
            IMG_BolitaPersonal_Lvl2.enabled = false;
            IMG_BolitaPersonal_Lvl3.enabled = false;
        }
        else if (nivelPersonal == 2)
        {
            infoTitle_Text.text = "Siguiente Nivel";
            infoPanel_Text.text = "Dos mesas se atenderán automaticamente";

            IMG_General.sprite = Resources.Load<Sprite>("Sprites/2");

            IMG_BolitaPersonal_Lvl1.enabled = true;
            IMG_BolitaPersonal_Lvl2.enabled = true;
            IMG_BolitaPersonal_Lvl3.enabled = false;
        }
        else if (nivelPersonal == 3)
        {
            infoTitle_Text.text = "Nivel maximo";
            infoPanel_Text.text = "¡Has completado todas las mejoras!";

            IMG_General.sprite = Resources.Load<Sprite>("Sprites/2");

            IMG_BolitaPersonal_Lvl1.enabled = true;
            IMG_BolitaPersonal_Lvl2.enabled = true;
            IMG_BolitaPersonal_Lvl3.enabled = true;
        }
    }

    public void MejorarMesas()
    {
        flechaPersonal.enabled = false;
        flechaMesas.enabled = true;
        flechaVitrinas.enabled = false;
        flechaDelivery.enabled = false;
    }
    public void InfoMejorarMesas()
    {
        if (nivelMesas == 1)
        {
            infoTitle_Text.text = "Siguiente Nivel";
            infoPanel_Text.text = "2 personas por mesa";

            IMG_General.sprite = Resources.Load<Sprite>("Sprites/2");

            IMG_BolitaMesas_Lvl1.enabled = true;
            IMG_BolitaMesas_Lvl2.enabled = false;
            IMG_BolitaMesas_Lvl3.enabled = false;
        }
        else if (nivelMesas == 2)
        {
            infoTitle_Text.text = "Siguiente Nivel";
            infoPanel_Text.text = "3 personas por mesa";

            IMG_General.sprite = Resources.Load<Sprite>("Sprites/2");

            IMG_BolitaMesas_Lvl1.enabled = true;
            IMG_BolitaMesas_Lvl2.enabled = true;
            IMG_BolitaMesas_Lvl3.enabled = false;
        }
        else if (nivelMesas == 3)
        {
            infoTitle_Text.text = "Nivel maximo";
            infoPanel_Text.text = "¡Has completado todas las mejoras!";

            IMG_General.sprite = Resources.Load<Sprite>("Sprites/2");

            IMG_BolitaMesas_Lvl1.enabled = true;
            IMG_BolitaMesas_Lvl2.enabled = true;
            IMG_BolitaMesas_Lvl3.enabled = true;
        }
    }


    public void MejorarVitrinas()
    {
        flechaPersonal.enabled = false;
        flechaMesas.enabled = false;
        flechaVitrinas.enabled = true;
        flechaDelivery.enabled = false;
    }
    public void InfoMejorarVitrinas()
    {
        if (nivelVitrinas == 1)
        {
            infoTitle_Text.text = "Siguiente Nivel";
            infoPanel_Text.text = "3 variedades de platos de comida";

            IMG_General.sprite = Resources.Load<Sprite>("Sprites/2");

            IMG_BolitaVitrinas_Lvl1.enabled = true;
            IMG_BolitaVitrinas_Lvl2.enabled = false;
            IMG_BolitaVitrinas_Lvl3.enabled = false;
        }
        else if (nivelVitrinas == 2)
        {
            infoTitle_Text.text = "Siguiente Nivel";
            infoPanel_Text.text = "4 variedades de platos de comida";

            IMG_General.sprite = Resources.Load<Sprite>("Sprites/2");

            IMG_BolitaVitrinas_Lvl1.enabled = true;
            IMG_BolitaVitrinas_Lvl2.enabled = true;
            IMG_BolitaVitrinas_Lvl3.enabled = false;
        }
        else if (nivelVitrinas == 3)
        {
            infoTitle_Text.text = "Nivel maximo";
            infoPanel_Text.text = "¡Has completado todas las mejoras!";

            IMG_General.sprite = Resources.Load<Sprite>("Sprites/2");

            IMG_BolitaVitrinas_Lvl1.enabled = true;
            IMG_BolitaVitrinas_Lvl2.enabled = true;
            IMG_BolitaVitrinas_Lvl3.enabled = true;
        }
    }

    public void MejorarDelivery()
    {
        flechaPersonal.enabled = false;
        flechaMesas.enabled = false;
        flechaVitrinas.enabled = false;
        flechaDelivery.enabled = true;
    }
    public void InfoMejorarDelivery()
    {
        if (nivelDelivery == 1)
        {
            infoTitle_Text.text = "Siguiente Nivel";
            infoPanel_Text.text = "20% de dinero de ingreso extra";

            IMG_General.sprite = Resources.Load<Sprite>("Sprites/2");

            IMG_BolitaDelivery_Lvl1.enabled = true;
            IMG_BolitaDelivery_Lvl2.enabled = false;
            IMG_BolitaDelivery_Lvl3.enabled = false;
        }
        else if (nivelDelivery == 2)
        {
            infoTitle_Text.text = "Siguiente Nivel";
            infoPanel_Text.text = "35% de dinero de ingreso extra";

            IMG_General.sprite = Resources.Load<Sprite>("Sprites/2");

            IMG_BolitaDelivery_Lvl1.enabled = true;
            IMG_BolitaDelivery_Lvl2.enabled = true;
            IMG_BolitaDelivery_Lvl3.enabled = false;
        }
        else if (nivelDelivery == 3)
        {
            infoTitle_Text.text = "Nivel maximo";
            infoPanel_Text.text = "¡Has completado todas las mejoras!";

            IMG_General.sprite = Resources.Load<Sprite>("Sprites/2");

            IMG_BolitaDelivery_Lvl1.enabled = true;
            IMG_BolitaDelivery_Lvl2.enabled = true;
            IMG_BolitaDelivery_Lvl3.enabled = true;
        }
    }

}
