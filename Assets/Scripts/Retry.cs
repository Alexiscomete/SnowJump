using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Retry : MonoBehaviour
{
    public void DoRetry()
    {
        SceneManager.LoadScene("Game");
        Console.WriteLine(22);
    }

}
