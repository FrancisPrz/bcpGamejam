using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BcpMenMovement1 : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;

    public List<GameObject> destinations = new List<GameObject>();

    public int indx;

    public bool arrived;
    public bool eating;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        indx = 0;
        arrived = false;
        eating = false;
    }

    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        if (arrived == false && eating == false)
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
