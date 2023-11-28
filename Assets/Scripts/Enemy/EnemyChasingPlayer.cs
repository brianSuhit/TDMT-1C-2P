using System.Collections.Generic;
using UnityEngine;

public class EnemyChasingPlayer : MonoBehaviour
{
    [SerializeField] private CharacterMovement characterMovement;
    [SerializeField] private float threshold = 0.0001f;
    [SerializeField] private List<Vector2> positions;

    [SerializeField] private CharacterMovement targetPos;

    private void Update()
    {
        ChasingPlayer();
    }

    private void ChasingPlayer()
    {
        if (targetPos == null)
        {
            Debug.LogError($"{name}: Target is null!");
            transform.position = Vector3.zero;
        }
        else if (Vector2.Distance(transform.position, targetPos.transform.position) > threshold)
        {
            Vector2 currentPosition = transform.position;
            Vector2 nextPosition = targetPos.transform.position;

            Vector2 directionToNextPos = nextPosition - currentPosition;
            directionToNextPos.Normalize();

            characterMovement.SetDirection(directionToNextPos);
        }
    }
}
