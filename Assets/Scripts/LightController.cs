using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
    public Light Ampul;
    public void ToggleLight()
    {
        Ampul.enabled = !Ampul.enabled;
    }

}
