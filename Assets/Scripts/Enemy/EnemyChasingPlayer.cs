using System.Collections.Generic;
using UnityEngine;

public class EnemyChasingPlayer : MonoBehaviour
{
    [SerializeField] private CharacterMovement characterMovement;
    [SerializeField] private float threshold = 0.0001f;
    [SerializeField] private List<Vector2> positions;
    private int currentIndex = 0;

    [SerializeField] private CharacterMovement targetPos;

    private void Update()
    {
        ChasingPlayer();
    }

    private void EnemyPatrol()
    {
        Vector2 nextPosition = positions[currentIndex];
        Vector2 currentPosition = transform.position;

        Vector2 directionToNextPos = nextPosition - currentPosition;
        directionToNextPos.Normalize();

        characterMovement.SetDirection(directionToNextPos);

        if ((currentPosition - nextPosition).magnitude <= threshold)
        {
            currentIndex++;
            if (currentIndex >= positions.Count)
            {
                currentIndex = 0;
            }
        }
    }

    private void ChasingPlayer()
    {
        Vector2 currentPosition = transform.position;
        Vector2 nextPosition = targetPos.transform.position;

        if (targetPos == null)
        {
            Debug.LogError($"{name}: Target is null!");
        }
        else if (Vector2.Distance(transform.position, targetPos.transform.position) > threshold)
        {
            Vector2 directionToNextPos = nextPosition - currentPosition;
            directionToNextPos.Normalize();

            characterMovement.SetDirection(directionToNextPos);
        }
    }
}
