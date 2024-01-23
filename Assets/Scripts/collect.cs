using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public float floatHeight = 1.0f;
    public float floatSpeed = 1.0f;
    public float rotationSpeed = 30.0f;

    private Vector3 startPosition;
    private int score = 1;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Caja flotante tocada por algo");

        ICoinCollector coinCollector = other.GetComponent<ICoinCollector>();

        if (coinCollector != null)
        {
            Debug.Log("ICoinCollector encontrado");
            coinCollector.CollectCoin(score);

        }
        else
        {
            Debug.Log("ICoinCollector NO encontrado en el objeto");
        }

        Destroy(gameObject);
    }
}
