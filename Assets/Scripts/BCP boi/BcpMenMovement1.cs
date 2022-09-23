using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class BcpMenMovement1 : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;

    public List<GameObject> destinations = new List<GameObject>();

    public int indx;

    public bool called = true;
    public bool arrived = false;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        indx = 0;
        called = true;
    }

    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        if (called == true && arrived == false)
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
