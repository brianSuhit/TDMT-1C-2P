using System;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float characterSpeed;
    private Vector2 _direction;

    private float multiplierSpeed = 2f;
    private bool isSpeedMultiplier = false;

    [SerializeField] private float xMin = 0f;
    [SerializeField] private float xMax = 0f;
    [SerializeField] private float yMin = 0f;
    [SerializeField] private float yMax = 0f;

    private void Update()
    {
        if (isSpeedMultiplier)
        {
            transform.position = transform.position + new Vector3(_direction.x, _direction.y) * characterSpeed * multiplierSpeed * Time.deltaTime;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), Mathf.Clamp(transform.position.y, yMin, yMax), 0);

        }
        else
        transform.position = transform.position + new Vector3(_direction.x, _direction.y) * characterSpeed * Time.deltaTime;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), Mathf.Clamp(transform.position.y, yMin, yMax), 0);

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
