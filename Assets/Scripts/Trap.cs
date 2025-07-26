using UnityEngine;

public class Trap : MonoBehaviour
{
    public int damageAmount = 20;

    void OnTriggerEnter(Collider other)
    {
        IDamageable damageable = other.GetComponent<IDamageable>();

        if (damageable != null)
        {
            damageable.TakeDamage(damageAmount);
        }

    }
}
