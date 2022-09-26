using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField] private string _tag;
    [SerializeField] private UnityEvent _onEnter, _onExit;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(_tag)) return;
        _onEnter.Invoke();
    }
    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag(_tag)) return;
        _onExit.Invoke();
    }
}