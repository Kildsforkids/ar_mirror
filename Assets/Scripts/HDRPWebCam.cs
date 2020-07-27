using UnityEngine;

public class HDRPWebCam : MonoBehaviour
{
    [SerializeField]
    private string targetProperty = "_BaseColorMap";

    private void Start()
    {
        var tex = new WebCamTexture();
        GetComponent<Renderer>().material.SetTexture(targetProperty, tex);
        tex.Play();
    }
}
