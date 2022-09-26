using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collisions : MonoBehaviour
{
    [SerializeField] private UnityEvent triggers;
    public Collider coll;
    public BcpMenMovement1 bcpMen;

    private void Start()
    {
        coll = GetComponent<Collider>();
        bcpMen = GameObject.FindGameObjectWithTag("BCP boi").GetComponent<BcpMenMovement1>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggers.Invoke();
            enabled = false;
            bcpMen.navMeshAgent.acceleration = 1f;
        }
    }
}
