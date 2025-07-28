using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int score = 0;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Diğer sahneye geçtiğinde silinmemesi için yazılır
        }

    }

    public void IncreaseScore()
    {
        score++;
        Debug.Log("Skor" + score);
    }

    public int GetScore()
    {
        return score;
    }

}
