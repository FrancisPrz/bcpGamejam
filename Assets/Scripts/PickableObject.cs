using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{
    public bool isPickable = true;
    public bool isPickableForNpc = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerInteraction"))
        {
            other.GetComponentInParent<PickUpObjects>().objectToPickUp = this.gameObject;
        }

        if (other.CompareTag("NpcInteraction"))
        {
            other.GetComponentInParent<PickUpObjectsNPC>().objectToPickUp = this.gameObject;
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
