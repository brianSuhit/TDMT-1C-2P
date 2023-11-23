using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour
{
    [SerializeField] private CharacterMovement characterMovement;
    [SerializeField] private Cannon cannon;

    public void SetMoveValue(InputAction.CallbackContext inputContext)
    {
        Vector2 inputValue = inputContext.ReadValue<Vector2>();
        characterMovement.SetDirection(inputValue);
    }

    public void SetShootingValue(InputAction.CallbackContext inputContext)
    {
        if (inputContext.started)
        {
            if (cannon == null)
            {
                Debug.LogError($"{name}: Cannon is null!");
                return;
            }
            cannon.Shoot();
        }
    }
}
