using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public struct EnemiesSpawner
    {
        public Transform spawnPoint;
        public GameObject enemiesInStruct;
    }

    [SerializeField] private Cannon cannon;
    private float shootTimer = 0f;
    [SerializeField] private float shootInterval;

    [SerializeField] private HealthPoints enemyHealth;
    [SerializeField] private HealthPoints playerHealth;
    [SerializeField] private CharacterMovement targetPos;

    [SerializeField] private List<HealthPoints> enemiesChasing;
    [SerializeField] private float spawnDelay = 10f;

    private List<EnemiesSpawner> enemiesList = new List<EnemiesSpawner>();
    [SerializeField] private List<Transform> spawnPointList;

    private int enemiesDeathCount = 0;

    private void Awake()
    {
        if (spawnPointList.Count != enemiesChasing.Count)
        {
            Debug.LogError($"enemiesChasing list and spawnPoint list are diferent or not the same lenght\n Check this values\n Disable component");
            enabled = false;
            return;
        }
    }

    private void Start()
    {
        for (int i = 0; i < enemiesChasing.Count; i++)
        {
            EnemiesSpawner tempEnemy;

            tempEnemy.enemiesInStruct = enemiesChasing[i].gameObject;

            tempEnemy.spawnPoint = spawnPointList[i];

            enemiesList.Add(tempEnemy);
        }

        StartCoroutine(SpawnEnemies());
    }

    private void Update()
    {
        BossMechanic();
    }

    private void OnEnable()
    {
        foreach (var item in enemiesChasing)
        {
            item.DeathEvent += EnemiesDeathCount;
        }
    }

    private void OnDisable()
    {
        foreach (var item in enemiesChasing)
        {
            item.DeathEvent -= EnemiesDeathCount;
        }
    }

    private void BossMechanic()
    {
        if (enemyHealth.health > 0 && playerHealth.health > 0)
        {
            if (cannon == null)
            {
                Debug.LogError($"{name}: CharacterShooting is null!");
                return;
            }
            if (playerHealth == null)
            {
                Debug.LogError($"{name}: player is null is null!");
            }
            else
            {
                Vector2 currentPosition = transform.position;
                Vector2 nextPosition = targetPos.transform.position;

                Vector2 directionToNextPos = nextPosition - currentPosition;
                directionToNextPos.Normalize();

                shootTimer += Time.deltaTime;

                if (shootTimer >= shootInterval)
                {
                    cannon.ShootWhitTarget(directionToNextPos);
                    shootTimer = 0f;
                }
            }
        }
    }

    private void EnemiesDeathCount()
    {
        enemiesDeathCount++;
        if (enemiesDeathCount == enemiesList.Count)
        {
            enemiesDeathCount = 0;
            StartCoroutine(SpawnEnemies());
        }
    }

    private IEnumerator SpawnEnemies()
    {
        foreach (EnemiesSpawner enemies in enemiesList)
        {
            enemies.enemiesInStruct.transform.position = enemies.spawnPoint.transform.position;

            enemies.enemiesInStruct.SetActive(true);

            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
