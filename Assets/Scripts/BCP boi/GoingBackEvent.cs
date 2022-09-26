using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingBackEvent : MonoBehaviour
{
    public BcpMenMovement1 bcpMen;

    public void GoingBack()
    {
        //if (bcpMen.arrived == true)
        {
            bcpMen.destinations.Reverse();
            //bcpMen.arrived = false;
            bcpMen.indx = 0;
        }
    }
}
