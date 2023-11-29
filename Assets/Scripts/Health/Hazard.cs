using UnityEngine;

public class Hazard : MonoBehaviour
{
    [SerializeField] private int damage;

    [SerializeField] private GameObject ExplosionEffect;
    [SerializeField] private AudioSource explosionClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject playerGameObject = collision.gameObject;

        HealthPoints playerHP = playerGameObject.GetComponent<HealthPoints>();

        if (playerHP != null)
        {
            playerHP.TakeDamage(damage);
            Instantiate(ExplosionEffect, transform.position, transform.rotation);

            if (object.ReferenceEquals(explosionClip, null))
            {
                Debug.LogError("Object destroy, dont play explosion sound");
            }
            else
            {
                explosionClip.Play();
            }
        }

        else
        {
            Debug.LogError($"{name}: player health is null");
        }
    }
}
