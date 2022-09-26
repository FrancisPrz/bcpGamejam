using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{
    private Wallet player;
    public bool isPickable = true;
    public bool isPickableForNpc = true;

    public int productNumber;

    public PedidoCliente pedidoCliente;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Wallet>();
    }
    void Update()
    {
        pedidoCliente = GameObject.FindGameObjectWithTag("BCP boi").GetComponent<PedidoCliente>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerInteraction"))
        {
            other.GetComponentInParent<PickUpObjects>().objectToPickUp = this.gameObject;
        }

        if (other.CompareTag("NpcInteraction"))
        {
            player.phisicalMoney += 10;
            Destroy(gameObject);
            if (pedidoCliente.nroPedido == productNumber)
            {
                other.GetComponentInParent<PickUpObjectsNPC>().objectToPickUp = this.gameObject;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerInteraction"))
        {
            other.GetComponentInParent<PickUpObjects>().objectToPickUp = null;
        }

        if (other.CompareTag("NpcInteraction"))
        {
            other.GetComponentInParent<PickUpObjectsNPC>().objectToPickUp = null;
        }
    }
}
