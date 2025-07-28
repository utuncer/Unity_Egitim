using System;
using UnityEngine;

public class EnemyPatrolManager : MonoBehaviour
{
    public Transform[] patrolNoktalari;
    public float hareketHizi = 3f;
    public float hedefeVarmaMesafesi = .3f;

    int currentIndex = 0;

    public float beklemeSuresi = 2f;

    private float beklemeSayacı = 0f;

    void Update()
    {
        if (beklemeSayacı > 0f)
        {
            beklemeSayacı -= Time.deltaTime;
        }
        else
        {
            PatrolYap();
        }
    }

    private void PatrolYap()
    {
        if (patrolNoktalari.Length == 0) return;
        //Vector3 hedefPos = patrolNoktalari[currentIndex].position;
        Vector3 hedefPos = new Vector3(patrolNoktalari[currentIndex].position.x, transform.position.y, patrolNoktalari[currentIndex].position.z);


        transform.LookAt(hedefPos);
        transform.position = Vector3.MoveTowards(transform.position, hedefPos, hareketHizi * Time.deltaTime);

        float mesafe = Vector3.Distance(transform.position, hedefPos);
        //Distance metodu İki nokta (veya pozisyon) arasındaki düz (doğrusal) mesafeyi hesaplar.
        if (mesafe < hedefeVarmaMesafesi)
        {
            beklemeSayacı = beklemeSuresi;
            currentIndex = (currentIndex + 1) % patrolNoktalari.Length;
        }

    }
}
