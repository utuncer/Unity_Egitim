using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI counterTXT;

    private void OnEnable() // Oyun nesnesi aktif hale geldiğinde (örneğin sahneye ilk girdiğinde veya SetActive(true) yapıldığında) çalışır.
    {
        CounterManager.clickCallBack += UpdateUI;
    }

    private void OnDisable() // Oyun nesnesi inaktif hale geldiğinde (örneğin SetActive(false) olduğunda ya da sahneden kaldırıldığında) çalışır.
    {
        CounterManager.clickCallBack -= UpdateUI;
    }

    public void UpdateUI(int counter)
    {
        counterTXT.text = counter.ToString();
    }
}
