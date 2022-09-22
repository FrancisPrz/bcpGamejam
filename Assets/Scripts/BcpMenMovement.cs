using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BcpMenMovement : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;

    public Transform[] destinations;

    public int indx;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        indx = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        navMeshAgent.destination = destinations[indx].transform.position;
        if (destinations[indx].transform.position.x == transform.position.x && destinations[indx].transform.position.z == transform.position.z)
        {
            indx++;
        }
        else if (indx == 3)
        {
            
        }

        
    }
}
