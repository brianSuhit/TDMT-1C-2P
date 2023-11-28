using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform cannonPoint;
    [SerializeField] private AudioSource cannonClip;

    public void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, cannonPoint.position, cannonPoint.rotation);
        cannonClip.Play();
        var bulletMovement = bullet.GetComponent<CharacterMovement>();
        bulletMovement.SetDirection(cannonPoint.up);
    }

    public void ShootWhitTarget(Vector2 bulletDirection)
    {
        var bullet = Instantiate(bulletPrefab, cannonPoint.position, cannonPoint.rotation);
        cannonClip.Play();
        var bulletMovement = bullet.GetComponent<CharacterMovement>();
        bulletMovement.SetDirection(bulletDirection.normalized);
    }
}
