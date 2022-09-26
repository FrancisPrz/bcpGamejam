using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjectsNPC : MonoBehaviour
{
    public GameObject objectToPickUp;
    public GameObject pickedObject;
    public Transform interactionZone;

    public HasFood food;
    public BcpMenCollisions menCollisions;
    public BcpMenMovement1 menMovement1;
    public PedidoCliente pedidoCliente;
    public InteractionPromptUI interactionPrompt;

    private void Start()
    {
        menMovement1 = GetComponent<BcpMenMovement1>();
        food = GetComponent<HasFood>();
        menCollisions = GetComponent<BcpMenCollisions>();
        pedidoCliente = GetComponent<PedidoCliente>();
    }

    void Update()
    {
        if (objectToPickUp != null && objectToPickUp.GetComponent<PickableObject>().isPickableForNpc == true && pickedObject == null)
        {
            pickedObject = objectToPickUp;
            pickedObject.GetComponent<PickableObject>().isPickable = false;
            pickedObject.transform.SetParent(interactionZone);
            pickedObject.transform.position = interactionZone.position;
            pickedObject.GetComponent<Rigidbody>().useGravity = false;
            pickedObject.GetComponent<Rigidbody>().isKinematic = true;
            food.food = pickedObject;
            pedidoCliente.atendido = true;
            Debug.Log("BCPboi agarro su comida");
            interactionPrompt.Close();
            menMovement1.doingSth = false;
            menMovement1.indx++;
        }
    }
}
