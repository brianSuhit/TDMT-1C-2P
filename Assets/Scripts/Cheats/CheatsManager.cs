using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CheatsManager : MonoBehaviour
{
    private Action InvincibleEvent;
    private Action SpeedMultiplierEvent;

    [SerializeField] private CharacterMovement characterMovement;
    [SerializeField] private HealthPoints healthPoints;
    [SerializeField] private List<HealthPoints> enemiesListCount = new List<HealthPoints>();
    [SerializeField] private int damageAOE = 5;

    public void Awake()
    {
        if (!healthPoints)
        {
            Debug.LogError("player has no heal");
        }

        if (enemiesListCount == null)
        {
            Debug.LogError($"{name}: enemies list is empty\n Check this assignment list\n disable component");
            enabled = false;
            return;
        }
    }

    public void Start()
    {
        InvincibleEvent = healthPoints.GetVulnerabilityChangeLogic();
        SpeedMultiplierEvent = characterMovement.GetSpeedChangeLogic();
    }

    public void SetInvulnerabilityState(InputAction.CallbackContext inputContext)
    {
        Debug.Log("Invulnerability cheat activated");

        if (inputContext.started)
        {
            InvincibleEvent?.Invoke();
        }
    }

    public void SetDamageAOE(InputAction.CallbackContext inputContext)
    {
        Debug.Log("Damage AOE cheat activated");

        if (inputContext.started)
        {
            MakeDamage();
        }
    }

    public void SetMovementSpeed(InputAction.CallbackContext inputContext)
    {
        Debug.LogError("Multiplier speed cheat activated");

        if (inputContext.started)
        {
            SpeedMultiplierEvent?.Invoke();
        }
    }

    public void MakeDamage()
    {
        for (int i = 0; i < enemiesListCount.Count; i++)
        {
            enemiesListCount[i].TakeDamage(damageAOE);
        }
    }
}
