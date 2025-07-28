using Unity.Mathematics;
using UnityEngine;


public class QuaternionManager : MonoBehaviour
{
    public Transform hedef;
    public Transform kendiEtrafindaDonenHedef;

    public float donmeHizi = 15f;

    void Update()
    {
        Vector3 hedefYon = hedef.position - transform.position;

        if (hedefYon != Vector3.zero)
        {
            Quaternion hedefRotasyon = Quaternion.LookRotation(hedefYon);
            transform.rotation = Quaternion.Slerp(transform.rotation, hedefRotasyon, donmeHizi * Time.deltaTime);
        }

        kendiEtrafindaDonenHedef.Rotate(Vector3.up * donmeHizi * Time.deltaTime);
    }

}
