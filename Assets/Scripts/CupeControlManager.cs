using UnityEngine;

public class CupeControlManager : MonoBehaviour
{
    /*
    - Vector3.zero → (0, 0, 0)
    - Vector3.one → (1, 1, 1)
    - Vector3.right → (1, 0, 0)
    - Vector3.left → (-1, 0, 0)
    - Vector3.up → (0, 1, 0)
    - Vector3.forward → (0, 0, 1)
    */
    Rigidbody rigibody;
    void Awake()
    {
        rigibody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = Vector3.up * 10f;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("Çalıştı");
            rigibody.linearVelocity = Vector3.zero; // linearVelocity nesnenin doğrusal (yani düz bir çizgideki) hızını ifade eder.
            rigibody.angularVelocity = Vector3.zero; // angularVelocity ise nesnenin kendi etrafında dönme hızını ifade eder.
        }
    }
}
