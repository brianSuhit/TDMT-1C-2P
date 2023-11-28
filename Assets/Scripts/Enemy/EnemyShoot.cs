using System.Collections;
using UnityEngine;
using static Boss;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private Cannon cannon;

    private float shootTimer = 0f;
    [SerializeField] private float shootInterval;

    private void Start()
    {
    }

    void Update()
    {
        Shooting();
    }

    private void Shooting()
    {
        shootTimer += Time.deltaTime;

        if (shootTimer >= shootInterval)
        {
            cannon.Shoot();
            shootTimer = 0f;
        }
    }
}
