using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void DoRetry()
    {
        SceneManager.LoadScene("Game");
    }
}
