using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Level 0";
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Level " + SpawnObstacles.wallLevel;
    }
}
