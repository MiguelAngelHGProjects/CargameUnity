using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
    public string nextLevelName = "SecondLevel"; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager scoreManager = ScoreManager.Instance;

            if (scoreManager != null && scoreManager.GetScore() >= 2)
            {
                Debug.Log("¡Nivel completado!");

                SceneManager.LoadScene(nextLevelName);
            }
            else
            {
                Debug.Log("Aún faltan cajas por recolectar.");
            }
        }
    }
}
