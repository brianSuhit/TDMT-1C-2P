using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private Cannon cannon;

    private float shootTimer = 0f;
    [SerializeField] private float shootInterval;

    void Update()
    {
        shootTimer += Time.deltaTime;

        if (shootTimer >= shootInterval)
        {
            cannon.Shoot();
            shootTimer = 0f;
        }
    }

}
