using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private Cannon cannon;

    private float shootTimer = 0f;
    [SerializeField] private float shootInterval;

    [SerializeField] private HealthPoints enemyHealth;
    [SerializeField] private HealthPoints playerHealth;


    void Update()
    {

        if (enemyHealth.health > 0 && playerHealth.health > 0) 
        {
            if (cannon == null)
            {
                Debug.LogError($"{name}: CharacterShooting is null!");
                return;
            }
            else
            {
                shootTimer += Time.deltaTime;

                if (shootTimer >= shootInterval)
                {
                    cannon.Shoot();
                    shootTimer = 0f;
                }
            }
        }
    }
}
