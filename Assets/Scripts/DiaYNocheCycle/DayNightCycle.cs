using UnityEngine;
using UnityEngine.Events;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField] private UnityEvent _onNight;
    private bool _lock;
    public float speed;
    public int rotationScale;

    void Update()
    {
        if (_lock) return;

        Vector3 rotation = transform.localEulerAngles;
        //print(rotation.x);
        rotation.x = rotation.x > 0 ? rotation.x -= Time.deltaTime * speed : 0;
        transform.localEulerAngles = rotation;

        if (rotation.x == 0 || rotation.x > 180)
        {
            _onNight.Invoke();
            _lock = true;
        }

        //transform.Rotate(rotationScale * Time.deltaTime, 0, 0);
    }
}
