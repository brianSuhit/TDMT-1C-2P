using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform cannonPoint;

    public void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, cannonPoint.position, cannonPoint.rotation);
        var bulletMovement = bullet.GetComponent<CharacterMovement>();
        bulletMovement.SetDirection(cannonPoint.up);
    }

    public void ShootWhitTarget(Vector2 bulletDirection)
    {
        var bullet = Instantiate(bulletPrefab, cannonPoint.position, cannonPoint.rotation);
        var bulletMovement = bullet.GetComponent<CharacterMovement>();
        bulletMovement.SetDirection(bulletDirection.normalized);
    }
}
