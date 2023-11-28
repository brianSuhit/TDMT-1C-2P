using System;
using UnityEngine;

public class DefuseBullet : MonoBehaviour
{
    //public Action InvisibleEvent;

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
        //InvisibleEvent?.Invoke();
    }
}
