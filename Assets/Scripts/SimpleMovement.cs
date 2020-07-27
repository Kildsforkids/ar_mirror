using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private float x, z;

    private void Update()
    {
        if ((x = Input.GetAxisRaw("Horizontal")) != 0)
        {
            transform.position += Vector3.right * x * Time.deltaTime * speed;
        }
        if ((z = Input.GetAxisRaw("Vertical")) != 0)
        {
            transform.position += Vector3.forward * z * Time.deltaTime * speed;
        }
    }
}
