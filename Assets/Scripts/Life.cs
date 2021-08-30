using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour
{
    int life = 10;
    bool canTakeDamage = true;
    public float waitTime;
    public float inTime;

    public SpriteRenderer spHead, spBody;

    public GameObject player, ob;
    public GameObject gameOverMenu;
    public Score score;

    public void TakeDamage(int damage)
    {
        if (canTakeDamage)
        {
            life -= damage;
            canTakeDamage = false;
            if (life > 0)
            {
                StartCoroutine(CantTakeDamage());
                StartCoroutine(Invisible());
            }
            else
            {
                gameOverMenu.SetActive(true);
                score.SetScore();
                ob.SetActive(false);
                player.SetActive(false);
            }
        }
    }

    public int GetLife()
    {
        return life;
    }

    IEnumerator CantTakeDamage()
    {
        yield return new WaitForSeconds(waitTime);
        canTakeDamage = true;
        spBody.color = new Color(255, 255, 255, 255);
        spHead.color = new Color(255, 255, 255, 255);
    }
    
    IEnumerator Invisible()
    {
        bool invisible = false;
        while (!canTakeDamage)
        {
            if (invisible)
            {
                spBody.color = new Color(255, 255, 255, 255);
                spHead.color = new Color(255, 255, 255, 255);
                invisible = false;
            }
            else
            {
                spBody.color = new Color(255, 255, 255, 0);
                spHead.color = new Color(255, 255, 255, 0);
                invisible = true;
            }
            yield return new WaitForSeconds(inTime);
        }
        spBody.color = new Color(255, 255, 255, 255);
        spHead.color = new Color(255, 255, 255, 255);
    }
}
