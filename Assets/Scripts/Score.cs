using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public Text text;

    void Start()
    {
        Console.WriteLine(22);
        text.text = "Your score : 0";
    }

    public void SetScore()
    {
        Console.WriteLine(SpawnObstacles.wallLevel * SpawnObstacles.wallLevel + SpawnObstacles.wallXP);
        text.text = "Your score : " + (SpawnObstacles.wallLevel * SpawnObstacles.wallLevel + SpawnObstacles.wallXP);
    }
}
