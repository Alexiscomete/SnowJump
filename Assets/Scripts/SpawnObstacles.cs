using System;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public static float wallSpeed = 2;
    int numberOfWalls = 0;

    public GameObject[] obstaclesTypes;
    public static List<GameObject> walls = new List<GameObject>();

    GameObject lastGameObject;

    public static Camera cameraStatic;
    public static float height, width;
    public Camera camera;

    public void Start()
    {
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
        
    }
}
