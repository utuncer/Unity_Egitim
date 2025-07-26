using UnityEngine;

public class Character
{
    public virtual void Attack()
    {
        Debug.Log("Karakter saldırıyor");
    }
}

public class Warrior : Character
{
    public override void Attack()
    {
        // base.Attack(); //-> Ana classdaki komutu çalıştıracak demektir
        Debug.Log("Savaşcı Saldırıyor");
    }
}

public class Mage : Character
{
    public override void Attack()
    {
        // base.Attack(); //-> Ana classdaki komutu çalıştıracak demektir
        Debug.Log("Büyücü Saldırıyor");
    }
}