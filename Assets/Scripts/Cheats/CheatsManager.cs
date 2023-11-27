using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CheatsManager : MonoBehaviour
{
    private Action InvinsibleEvent;

    [SerializeField] private HealthPoints healthPoints;

    public void Awake()
    {
        if (!healthPoints)
        {
            Debug.LogError("player has no heal");
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
}
