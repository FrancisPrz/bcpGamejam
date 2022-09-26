using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BcpMenMovement1 : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    private Rigidbody rb;

    public List<GameObject> destinations = new List<GameObject>();

    public int indx;

    public bool doingSth;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
        indx = 0;
        doingSth = false;
    }

    void Update()
    {
        Movement();

        if(indx == destinations.Count)
        {
            Destroy(gameObject, 1f);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector3.zero;
    }

    public void Movement()
    {
        if (doingSth == false)
        {
            navMeshAgent.destination = destinations[indx].transform.position;
        }

        if (destinations[indx].transform.position.x == transform.position.x 
            && destinations[indx].transform.position.z == transform.position.z)
        {
            indx++;
        }
    }
}
