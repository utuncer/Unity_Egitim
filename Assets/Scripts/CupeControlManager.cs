using UnityEngine;

public class CupeControlManager : MonoBehaviour
{
    Vector3 vector = new Vector3(1f, 2f, 3f);
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = vector;
        }
    }
}
