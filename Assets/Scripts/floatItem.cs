using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatItem : MonoBehaviour
{
    public float floatHeight = 1.0f;
    public float floatSpeed = 1.0f;
    public float rotationSpeed = 30.0f;
    private Vector3 startPosition;

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

}
    