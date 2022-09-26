using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    public NavMeshAgent meshAgent;
    public Transform point;
    private Vector3 start;

    IEnumerator Start()
    {
        start = transform.position;
        point = GameObject.FindGameObjectWithTag("Point").transform;
        meshAgent.SetDestination(point.position);
        yield return new WaitUntil(()=>meshAgent.remainingDistance <= 0.1f);
        yield return new WaitForSeconds(15f);
        meshAgent.SetDestination(start);
    }

    public void Interact()
    {
        StopAllCoroutines();

        meshAgent.SetDestination(start);
    }
}
