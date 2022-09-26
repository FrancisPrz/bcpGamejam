using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BcpMenCollisions : MonoBehaviour
{
    public BcpMenMovement1 bcpMen;
    public HasFood hasFood;
    public PedidoCliente pedidoCliente;
    public GameObject colliderToPay;

    public Collider readyToPickUpFood;

    public InteractionPromptUI interactionPrompt;

    public bool estaEnCaja;

    private void Start()
    {
        bcpMen = GetComponent<BcpMenMovement1>();
        hasFood = GetComponent<HasFood>();
        pedidoCliente = GetComponent<PedidoCliente>();
        colliderToPay = GameObject.FindGameObjectWithTag("toPay");
        estaEnCaja = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("paying"))
        {
            colliderToPay.SetActive(true);
            bcpMen.doingSth = true;
            estaEnCaja = true;
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
