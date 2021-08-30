using UnityEngine;
using UnityEngine.UI;


public class LifeText : MonoBehaviour
{
    public Text text;
    public Life life;

    void Start()
    {
        text.text = "10 HP";
    }

    void Update()
    {
        text.text = life.GetLife() + " HP";
    }
}
