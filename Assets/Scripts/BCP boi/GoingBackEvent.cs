using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingBackEvent : MonoBehaviour
{
    public BcpMenMovement1 bcpMen;

    public void GoingBack()
    {
        bcpMen.destinations.Reverse();
        bcpMen.called = true;
        bcpMen.arrived = false;
    }
}
