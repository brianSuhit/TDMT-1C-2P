using UnityEngine;

public class BulletChasingEnemy : MonoBehaviour
{
    [SerializeField] private Cannon cannon;
    private float shootTimer = 0f;
    [SerializeField] private float shootInterval;

    [SerializeField] private HealthPoints enemyHealth;
    [SerializeField] private HealthPoints playerHealth;
    [SerializeField] private CharacterMovement targetPos;


    void Update()
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
}
