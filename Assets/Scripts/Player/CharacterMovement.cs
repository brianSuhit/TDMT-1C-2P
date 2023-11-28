using System;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float characterSpeed;
    private Vector2 _direction;

    private float multiplierSpeed = 2f;
    private bool isSpeedMultiplier = false;

    private void Update()
    {
        if (isSpeedMultiplier)
        {
            transform.position = transform.position + new Vector3(_direction.x, _direction.y) * characterSpeed * multiplierSpeed * Time.deltaTime;
        }
        else
        transform.position = transform.position + new Vector3(_direction.x, _direction.y) * characterSpeed * Time.deltaTime;
    }

    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }

    public void ChangeSpeed()
    {
        isSpeedMultiplier = !isSpeedMultiplier;
    }

    public Action GetSpeedChangeLogic()
    {
        return ChangeSpeed;
    }
}
