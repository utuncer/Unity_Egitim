using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public float hiz = 2f;

    public float hareketeBaslamaMesafesi = 5f;

    public float durmaMesafesi = 2f;

    void Update()
    {
        float mesafe = Vector3.Distance(transform.position, player.position);

        // Hareket mesafesi aralıkta mı?
        if (mesafe < hareketeBaslamaMesafesi && mesafe > durmaMesafesi)
        {
            // Vector3.MoveTowards(gecerliPozisyon, hedefPozisyon, gidilecekSure)
            transform.position = Vector3.MoveTowards(transform.position, player.position, hiz * Time.deltaTime);

        }


    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, hareketeBaslamaMesafesi);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, durmaMesafesi);

    }


}


