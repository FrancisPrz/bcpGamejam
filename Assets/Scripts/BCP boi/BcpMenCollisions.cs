using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BcpMenCollisions : MonoBehaviour
{
    public BcpMenMovement1 bcpMen;
    public HasFood hasFood;
    public PedidoCliente pedidoCliente;
    public Collisions colliderToPay;

    public Collider readyToPickUpFood;

    public InteractionPromptUI interactionPrompt;

    private void Start()
    {
        bcpMen = GetComponent<BcpMenMovement1>();
        hasFood = GetComponent<HasFood>();
        pedidoCliente = GetComponent<PedidoCliente>();
        colliderToPay = GetComponent<Collisions>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("paying"))
        {
            colliderToPay.enabled = true;
            bcpMen.doingSth = true;
            Debug.Log("BCPboi quiere ordenar algo.");
        }

        if (other.gameObject.CompareTag("waiting"))
        {
            readyToPickUpFood.enabled = true;
            interactionPrompt.SetUp("");
            Debug.Log("BCPboi llego a pedir comida");
        }

        if (other.gameObject.CompareTag("eating"))
        {
            Debug.Log("BCPboi llego a su mesa");
            hasFood.EatingFood();
        }
    }
}
