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
}
