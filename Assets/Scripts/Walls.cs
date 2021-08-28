using UnityEngine;

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
                GameObject ob = Instantiate(wall, new Vector3(wallsX[i], wallsY[i], 0), Quaternion.identity);
                ob.transform.SetParent(transform);
            }
            else
            {
                break;
            }
        }
    }
}
