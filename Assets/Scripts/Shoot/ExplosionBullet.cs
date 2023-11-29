using UnityEngine;

public class ExplosionBullet : MonoBehaviour
{
    [SerializeField] private GameObject ExplosionEffect;
    [SerializeField] private AudioSource explosionClip;

    private void OnDestroy()
    {
        Instantiate(ExplosionEffect, transform.position, transform.rotation);
        //explosionClip.Play();

        if (object.ReferenceEquals(explosionClip, null))
        {
            Debug.LogError("Object destroy, dont play explosion sound");
        }
        else
        {
            explosionClip.Play();
        }
    }
}
