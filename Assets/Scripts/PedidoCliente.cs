using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PedidoCliente : MonoBehaviour
{

    public Sprite[] imagenesComidas = new Sprite[3];
    public Image imagenPedido;
    public Sprite[] imagenAnimo = new Sprite[2];

    public float tiempoAtencion;
    public bool atendido;
    public float counter;
    
    void Start()
    {
        atendido = false;
        int nroPedido = Random.Range(0, imagenesComidas.Length - 1);
        Debug.Log(nroPedido);
        imagenPedido.sprite = imagenesComidas[nroPedido];
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;

        if (atendido)
        {
            imagenPedido.sprite = imagenAnimo[0];
            Retirada();
        }

        if (counter > tiempoAtencion && !atendido)
        {
            imagenPedido.sprite = imagenAnimo[1];
            Retirada();
        }
    }

    public void Retirada()
    { 
    
    }
}
