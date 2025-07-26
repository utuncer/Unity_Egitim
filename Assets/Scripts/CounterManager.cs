using System;
using UnityEngine;

public class CounterManager : MonoBehaviour
{
    public static Action<int> clickCallBack;
    //Action<int>: bir adet int parametre alan ama geri değer döndürmeyen bir metodu temsil eder.
    private int ClickCounter = 0;

    private void OnMouseDown()
    {
        ClickCounter++;
        Debug.Log(ClickCounter);

        // if (clickCallBack != null)
        // {
        //     clickCallBack(ClickCounter);
        // }

        clickCallBack?.Invoke(ClickCounter); // if yerine bu şekilde yazılım yapılabilir

    }
}
