using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float characterSpeed;
    private Vector2 _direction;

    private void Update()
    {
        transform.position = transform.position + new Vector3(_direction.x, _direction.y) * characterSpeed * Time.deltaTime;
    }

    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }
}
