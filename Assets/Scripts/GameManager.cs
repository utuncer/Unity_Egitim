using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Character warrior = new Warrior();
        Character mage = new Mage();

        warrior.Attack();
        mage.Attack();
    }
}
