using System.Collections;
using UnityEngine;

public class ExplosionBullet : MonoBehaviour
{
    [SerializeField] private GameObject ExplosionEffect;
    [SerializeField] private AudioSource explosionClip;
    //[SerializeField] private DefuseBullet defuseBullet;
    //[SerializeField] private HealthPoints healthPoints;
    //[SerializeField] private float waitForDestroy = 0.5f;

    private void OnDestroy()
    {
        Instantiate(ExplosionEffect, transform.position, transform.rotation);
        explosionClip.Play();
    }

    //private void Awake()
    //{
    //    if (ExplosionEffect == null)
    //    {
    //        Debug.LogError($"explosion effect is null");
    //        enabled = false;
    //        return;
    //    }
    //    if (defuseBullet == null)
    //    {
    //        Debug.LogError($"defuse bullet  is null");
    //        enabled = false;
    //        return;
    //    }
    //    if (healthPoints == null)
    //    {
    //        Debug.LogError($"HealthPoints is null");
    //        enabled = false;
    //        return;
    //    }
    //}

    //private void OnEnable()
    //{
    //    defuseBullet.InvisibleEvent += AnimationDestroyLogic;
    //    healthPoints.DeathEvent += AnimationDestroyLogic;
    //}

    //private void OnDisable()
    //{
    //    defuseBullet.InvisibleEvent -= AnimationDestroyLogic;
    //    healthPoints.DeathEvent -= AnimationDestroyLogic;
    //}

    //private void AnimationDestroyLogic()
    //{
    //    Instantiate(ExplosionEffect, transform.position, transform.rotation);
    //    StartCoroutine(WaitForDestroy());
    //}

    //private IEnumerator WaitForDestroy()
    //{
    //    yield return new WaitForSeconds(waitForDestroy);
    //    Destroy(gameObject);
    //}
}
