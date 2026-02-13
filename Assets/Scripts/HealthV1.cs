using UnityEngine;

public class HealthV1 : MonoBehaviour
{
    public int hp = 100;

    public void TakeDamage(int damage)
    {
        hp = hp - damage;
        Debug.Log($"{gameObject.name} took {damage} damage. HP left = {hp}");

        if (hp <= 0)
        {
            Debug.Log($"{gameObject.name} died!");
            Destroy(gameObject);
        }
    }
}
