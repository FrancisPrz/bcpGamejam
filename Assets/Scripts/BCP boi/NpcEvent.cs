using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NpcEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent eventos;

    private void OnTriggerEnter(Collider other)
    {
    }
}
