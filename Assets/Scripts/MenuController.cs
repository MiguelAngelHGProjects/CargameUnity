using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Iniciar juego...");

        SceneManager.LoadSceneAsync("FirstLevel");
    }

}
