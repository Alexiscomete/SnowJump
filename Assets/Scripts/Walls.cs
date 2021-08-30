using UnityEngine;
using System;

public class Walls : MonoBehaviour
{
    public int height, wight;
    public int[] wallsX;
    public int[] wallsY;

    public GameObject wall;

    private void Start()
    {
        for (int i  = 0; i < wallsX.Length; i++)
        {
            if (wallsY.Length -1 >= i)
            {
                GameObject ob = Instantiate(wall, new Vector3(wallsX[i] + transform.position.x, wallsY[i], 0), Quaternion.identity);
                ob.transform.SetParent(transform);
            }
            else
            {
                break;
            }
        }
    }

    private void Update()
    {
        if (transform.position.x < (-SpawnObstacles.wallSpeed - wight - (SpawnObstacles.width / 2)))
        {
            Console.WriteLine(-SpawnObstacles.wallSpeed - wight - (SpawnObstacles.width / 2));
            Console.WriteLine(SpawnObstacles.width);
            SpawnObstacles.walls.RemoveAt(0);
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmos()
    {
        for (int i = 0; i < wallsX.Length; i++)
        {
            if (wallsY.Length - 1 >= i)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(new Vector3(wallsX[i] + transform.position.x, wallsY[i], 0), 0.2f);
            }
            else
            {
                break;
            }
        }
    }
}
