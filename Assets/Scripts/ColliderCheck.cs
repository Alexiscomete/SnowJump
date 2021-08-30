using UnityEngine;

public class ColliderCheck : MonoBehaviour
{
    public Life life;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        life.TakeDamage(1);
    }
}
