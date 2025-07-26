using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    public delegate void TriggerEvent();
    public static event TriggerEvent onTriggered;
    //event: Bu, bir olay (event) tanımlar. Olaylar, başka nesnelerin bir şeyin olduğunu "duyması" için kullanılır.
    private void OnTriggerEnter(Collider other)
    {
        onTriggered?.Invoke();
    }
}
