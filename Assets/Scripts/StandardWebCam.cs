using UnityEngine;

public class StandardWebCam : MonoBehaviour
{
    private Renderer rend;

    private void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        Debug.Log($"Количество подключенных вебок: {devices.Length}");
        rend = this.GetComponent<Renderer>();
        WebCamTexture mycam = new WebCamTexture();
        string camName = devices[0].name;
        Debug.Log($"Навзание: {camName}");
        mycam.deviceName = camName;
        rend.material.mainTexture = mycam;

        mycam.Play();
    }
}
