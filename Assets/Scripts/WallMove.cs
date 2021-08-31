using UnityEngine;

public class WallMove : MonoBehaviour
{
    void Update()
    {
        transform.Translate(- SpawnObstacles.wallSpeed * Time.deltaTime, 0, 0);
    }
}
