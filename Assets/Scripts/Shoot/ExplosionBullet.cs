using UnityEngine;

public class ExplosionBullet : MonoBehaviour
{
    [SerializeField] private GameObject ExplosionEffect;

    private void OnDestroy()
    {
        if (ExplosionEffect)
        {
            Instantiate(ExplosionEffect, transform.position, transform.rotation);
        }
    }
}
