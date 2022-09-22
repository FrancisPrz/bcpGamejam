using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collisions : MonoBehaviour
{
    [SerializeField] private UnityEvent triggers;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggers.Invoke();
        }
    }
}
