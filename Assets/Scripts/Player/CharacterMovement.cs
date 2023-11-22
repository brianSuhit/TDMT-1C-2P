using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float characterSpeed;
    [SerializeField] private Vector2 inputValue;

    private void Update()
    {
        transform.position = transform.position + new Vector3(inputValue.x, inputValue.y) * characterSpeed * Time.deltaTime;
    }
    //TODO: TP2 - Move all input reads to specific class
    public void SetMovementValue(InputAction.CallbackContext inputContext)
    {
        inputValue = inputContext.ReadValue<Vector2>();
        Debug.Log($"{gameObject}: Event risen. Value: {inputValue}");
    }
}
