using System;
using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
    public Light Ampul;
    private void OnEnable()
    {
        TriggerZone.onTriggered += TurnOnLight;
    }
    private void OnDisable()
    {
        TriggerZone.onTriggered -= TurnOnLight;
    }

    private void TurnOnLight()
    {
        Ampul.enabled = !Ampul.enabled;
    }
}
