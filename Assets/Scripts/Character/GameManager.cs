using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player = new Player();
        player.Move();
        player.Jump();

        Enemy enemy = new Enemy();
        enemy.Move();
        enemy.Attack();
    }

}
