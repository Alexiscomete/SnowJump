using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public static float wallSpeed = 3;
    public static int wallXP, wallLevel = 0;

    public GameObject[] obstaclesTypes;
    public static List<GameObject> walls;

    GameObject lastGameObject;

    public static Camera cameraStatic;
    public static float height, width;
    public Camera camera;

    public void Start()
    {
        wallSpeed = 3;
        wallXP = 0;
        wallLevel = 0;
        walls = new List<GameObject>();
        cameraStatic = camera;
        height = 2f * camera.orthographicSize;
        width = height * camera.aspect;
        GameObject ob = Instantiate(obstaclesTypes[0], new Vector3(width / 2 + 2, 0, 0), Quaternion.identity);
        ob.transform.SetParent(transform);
        walls.Add(ob);
        lastGameObject = ob;
    }

    // Update is called once per frame
    void Update()
    {
        if (lastGameObject.transform.position.x < 0)
        {
            int rint = new System.Random().Next(wallLevel);
            GameObject ob = Instantiate(obstaclesTypes[rint], new Vector3(width / 2 + 2, 0, 0), Quaternion.identity);
            ob.transform.SetParent(transform);
            walls.Add(ob);
            lastGameObject = ob;
            wallXP++;
            if (wallXP > wallLevel && wallLevel < obstaclesTypes.Length)
            {
                wallXP = 0;
                wallLevel++;
                wallSpeed += 0.3f;
            }
        }
    }
}
