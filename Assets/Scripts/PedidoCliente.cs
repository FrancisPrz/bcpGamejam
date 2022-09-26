using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PedidoCliente : MonoBehaviour
{

    public Sprite[] imagenesComidas = new Sprite[4];
    public Image imagenPedido;
    public Sprite[] imagenAnimo = new Sprite[2];

    public int nroPedido;

    public float tiempoAtencion;
    public bool atendido;
    public float counter;


    public BcpMenMovement1 bcpMen;
    public BcpMenCollisions menCollisions;
    
    void Start()
    {
        atendido = false;
        nroPedido = Random.Range(0, imagenesComidas.Length);
        Debug.Log(nroPedido);
        imagenPedido.sprite = imagenesComidas[nroPedido];
        bcpMen = GetComponent<BcpMenMovement1>();
        menCollisions = GetComponent<BcpMenCollisions>();
    }

    void Update()
    {
        if (menCollisions.estaEnCaja)
        {
            counter += Time.deltaTime;
        }

        if (atendido)
        {
            imagenPedido.sprite = imagenAnimo[0];
            //Retirada();
        }

        if (counter > tiempoAtencion && !atendido)
        {
            imagenPedido.sprite = imagenAnimo[1];
            bcpMen.doingSth = false;
            Retirada();
        }
    }

    public void Retirada()
    {
        bcpMen.indx = bcpMen.destinations.Count - 1;
    }
}
