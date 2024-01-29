using UnityEngine;

public class CambiarCamara : MonoBehaviour
{
    public Camera cameraP;
    public Camera cameraS;

    void Start()
    {
        cameraS.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleCameras();
        }
    }

    void ToggleCameras()
    {
        cameraP.enabled = !cameraP.enabled;
        cameraS.enabled = !cameraS.enabled;
    }
}
