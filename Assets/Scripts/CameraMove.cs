using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject head, body;
    public float timeOffSet;
    public Vector3 posOffSet;

    public Vector3 velocity;

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, ((head.transform.position + body.transform.position) / 2) + posOffSet, ref velocity, timeOffSet);
    }
}
