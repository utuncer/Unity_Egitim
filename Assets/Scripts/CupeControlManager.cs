using UnityEngine;

public class CupeControlManager : MonoBehaviour
{
    Vector3 vector = new Vector3(4, 3, 0);
    Vector3 birimVector;
    void Start()
    {
        birimVector = vector.normalized;

        Debug.Log(birimVector); // (0.80, 0.60, 0.00)
        Debug.Log(vector); // (4.00, 3.00, 0.00)
        vector.Normalize();
        Debug.Log(vector); // (0.80, 0.60, 0.00)

    }
}
