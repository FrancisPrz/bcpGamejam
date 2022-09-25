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
            Debug.Log("BCPboi agarro su comida");
            menMovement1.arrived = false;
            menMovement1.indx++;
        }
    }
}
