using UnityEngine;

public class GameManager : MonoBehaviour
{
    public delegate void LevelUpAction();

    public LevelUpAction onLevelUp;

    private void Start()
    {
        onLevelUp = PlaySound;
        onLevelUp += ShowUI;
        onLevelUp -= PlaySound;

        if (onLevelUp != null)
            onLevelUp();
    }

    void PlaySound()
    {
        Debug.Log("Oyun Müziği Çalındı");
    }
    void ShowUI()
    {
        Debug.Log("UI Ekranı Gösterildi");
    }
}
