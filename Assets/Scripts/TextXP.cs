using UnityEngine;
using UnityEngine.UI;

public class TextXP : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "0 XP";
    }

    // Update is called once per frame
    void Update()
    {
        text.text = SpawnObstacles.wallXP + " XP";
    }
}