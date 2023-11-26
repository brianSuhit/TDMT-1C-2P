using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] public int maxHealth = 100;
    [SerializeField] public int health = 100;

    [SerializeField] private bool shouldDestroyOnDeath;
    [SerializeField] private bool isEnemy;

    public void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (isEnemy && damage == 1)
        {
            health -= damage;
        }

        if (shouldDestroyOnDeath && health <= 0)
        {
            Destroy(gameObject);
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }

        if (isEnemy && health <= 0)
        {
            GameObject.FindGameObjectWithTag("LevelChangeShip").GetComponent<GameplayLevelChange>().EnemiesEliminated();
        }
    }
}
