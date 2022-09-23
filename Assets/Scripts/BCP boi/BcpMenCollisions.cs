using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BcpMenCollisions : MonoBehaviour
{
    [SerializeField] private UnityEvent trigger;

    public BcpMenMovement1 bcpMen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BCP boi"))
        {
            bcpMen.arrived = true;
            if(!bcpMen.arrived) trigger?.Invoke();
        }
    }
}
