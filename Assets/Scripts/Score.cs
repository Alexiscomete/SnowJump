using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;

    void Start()
    {
        text.text = "Your score : " + ((SpawnObstacles.wallLevel * SpawnObstacles.wallLevel) + SpawnObstacles.wallXP);
    }
}
