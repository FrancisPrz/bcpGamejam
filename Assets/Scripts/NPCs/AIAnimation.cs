using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIAnimation : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator anim;
    private void Start() {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
    private void Update() {
        anim.SetFloat("Speed", agent.velocity.magnitude);
    }
}
