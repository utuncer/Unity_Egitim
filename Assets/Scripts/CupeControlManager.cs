using UnityEngine;

public class CupeControlManager : MonoBehaviour
{
    public Transform enemyPosition;

    Vector3 directionVector;

    float mesafe;

    void Update()
    {
        if (enemyPosition == null || enemyPosition.gameObject == null) return;
        directionVector = transform.position - enemyPosition.position;
        mesafe = directionVector.magnitude; // magnitude metodu vectörün uzunluğunu verir
        Debug.Log(mesafe);
        if (mesafe < 2)
        {
            Destroy(enemyPosition.gameObject);
            enemyPosition = null;
        }
    }
}
