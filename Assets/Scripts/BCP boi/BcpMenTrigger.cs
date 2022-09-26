using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BcpMenTrigger : MonoBehaviour
{
    public BcpMenMovement1 menMovement1;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("arrived"))
        {
            //menMovement1.arrived = true;
            Debug.Log("LLEGO");
        }
    }
}
