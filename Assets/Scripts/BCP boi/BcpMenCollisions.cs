using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BcpMenCollisions : MonoBehaviour
{
    public BcpMenMovement1 bcpMen;
    public GoingBackEvent goingBack;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("arrived"))
        {
            bcpMen.arrived = true;
            Debug.Log("LlegoBCPboi");
            goingBack.GoingBack();
        }
    }
}
