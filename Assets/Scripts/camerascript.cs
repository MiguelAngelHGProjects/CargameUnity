using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    public GameObject player;

    void Start()
    {        
        Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false; 
    }

    void LateUpdate()
    {
        
    }
}
