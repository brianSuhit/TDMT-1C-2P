using System;
using System.Collections;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    public Action DeathEvent;

    [SerializeField] public int maxHealth = 100;
    [SerializeField] public int health = 100;

    [SerializeField] private bool shouldDestroyOnDeath;
    [SerializeField] private bool isEnemy; 

    private bool isVulnerable = true;
    //[SerializeField] private float waitForDestroy = 0.5f;

    public void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (isVulnerable)
        {
            health -= damage;
        }

        if (isEnemy && damage == 1)
        {
            health -= damage;
        }

        if (shouldDestroyOnDeath && health <= 0)
        {
            Destroy(gameObject);
            //StartCoroutine(WaitForDesactivated());
        }

        if (health <= 0)
        {
            DeathEvent?.Invoke();
            gameObject.SetActive(false);
        }
    }

    private void ChangeVulnerability()
    {
        isVulnerable = !isVulnerable;
    }

    public Action GetVulnerabilityChangeLogic()
    {
        return ChangeVulnerability;
    }

    //private IEnumerator WaitForDesactivated()
    //{
    //    gameObject.SetActive(false);
    //    yield return new WaitForSeconds(waitForDestroy);
    //}
}
