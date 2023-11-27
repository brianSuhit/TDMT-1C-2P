using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CheatsManager : MonoBehaviour
{
    private Action InvinsibleEvent;

    [SerializeField] private HealthPoints healthPoints;
    [SerializeField] private List<HealthPoints> enemiesListCount = new List<HealthPoints>();
    [SerializeField] private int damageAOE = 5;


    public void Awake()
    {
        if (!healthPoints)
        {
            Debug.LogError("player has no heal");
        }

        if (enemiesListCount.Count == 0)
        {
            Debug.LogError($"{name}: enemies list is empty\n Check this assignment list\n disable component");
            enabled = false;
            return;
        }
    }

    public void Start()
    {
        InvinsibleEvent = healthPoints.GetVulnerabilityChangeLogic();
    }

    public void SetInvulnerabilityState(InputAction.CallbackContext inputContext)
    {
        Debug.Log("me estoy apretando");

        if (inputContext.started)
        {
            InvinsibleEvent?.Invoke();
        }
    }

    public void SetDamageAOE(InputAction.CallbackContext inputContext)
    {
        Debug.Log("me estoy apretando");

        if (inputContext.started)
        {
            MakeDamage();
        }
    }

    public void SetMovementSpeed(InputAction.CallbackContext inputContext)
    {
        if (inputContext.started)
        {
            SpeedMultiplier();
        }
    }

    public void SpeedMultiplier()
    {
        Debug.LogError("Need a reference");
    }

    public void MakeDamage()
    {
        for (int i = 0; i < enemiesListCount.Count; i++)
        {
            enemiesListCount[i].TakeDamage(damageAOE);
        }
    }
}
