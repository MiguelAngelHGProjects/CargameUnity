using UnityEngine;

public class CarController : MonoBehaviour, ICoinCollector
{
    public Transform[] wheels;
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    void Update()
    {
        Vector2 movementInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        float moveSpeed = movementInput.y * speed;

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * movementInput.x * rotationSpeed * Time.deltaTime);

        foreach (Transform wheel in wheels)
        {
            wheel.Rotate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ReplayGame();
        }

        if (transform.position.y < -1.5)
        {
            ReplayGame();
        }
    }

    public void CollectCoin(int value)
    {
        ScoreManager.Instance.UpdateScore(value);
        Debug.Log("Moneda recolectada. Nuevo puntaje: " + ScoreManager.Instance.GetScore());

    }

    void ReplayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
