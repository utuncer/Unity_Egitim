using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Transform Player;

    NavMeshAgent Enemy;

    void Awake()
    {
        Enemy = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        Enemy.SetDestination(Player.position);
    }
}
