using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public int health = 100;
    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Enemy Saldırıya Uğradı " + health);
    }

}
