using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    public UnityEvent onTriggerEnter;
    private void OnTriggerEnter(Collider other)
    {
        //tetiklenince event çalışır
        onTriggerEnter?.Invoke();
    }
}
