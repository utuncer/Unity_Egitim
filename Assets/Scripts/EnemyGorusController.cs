using UnityEngine;

public class EnemyGorusController : MonoBehaviour
{
    public Renderer renderer;
    public Transform player;


    void Update()
    {
        // Düşmandan oyuncuya yön
        Vector3 hedefYon = player.position - transform.position;

        hedefYon.Normalize();

        //Düşmanın ileri yönü
        Vector3 enemyForward = transform.forward;

        //Kendisinden oyuncuya olan yönüyle ileri yönünün arasındaki açı
        float dot = Vector3.Dot(hedefYon, enemyForward);

        if (dot > .7f)
        {
            renderer.material.color = Color.red;
        }
        else
        {
            renderer.material.color = Color.green;
        }
        //Düşmanın ileri yön çizgisi
        Debug.DrawRay(transform.position, enemyForward * 2, Color.blue);

        //Düşmanla oyuncu arasındaki çizgi
        Debug.DrawRay(transform.position, hedefYon * 2, Color.yellow);
    }
}
