using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BcpMenCollisions : MonoBehaviour
{
    public BcpMenMovement1 bcpMen;

    public Collider readyToPickUpFood;

    public HasFood hasFood;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("arrived"))
        {
            readyToPickUpFood.enabled = true;

            Debug.Log("Llego BCPboi a pedir comida");
        }

        if (other.gameObject.CompareTag("eating"))
        {
            Debug.Log("BCPboi llego a su mesa");
            hasFood.EatingFood();
        }
    }
}
