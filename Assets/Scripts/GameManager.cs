using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private int collectedBoxes = 0;
    public int totalBoxes = 2; 
    public string second = "Second level"; 

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    public void CollectBox()
    {
        collectedBoxes++;

        if (collectedBoxes >= totalBoxes)
        {
            SceneManager.LoadScene(second, LoadSceneMode.Additive);
        }
    }
}
