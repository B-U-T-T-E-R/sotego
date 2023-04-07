using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int movementDirection = 1;
    public int movingTo = 0;
    public Transform[] PathElements;

    private void FixedUpdate()
    {
        if (movementDirection == -1)
            Die();
    }

    public IEnumerator<Transform> GetNextPathPoint()
    {
        if (PathElements == null || PathElements.Length < 1)
        {
            yield break;
        }

        while (true)
        {
            yield return PathElements[movingTo];

            if (PathElements.Length == 1)
            {
                continue;
            }

            if (movingTo <= 0)
            {
                movementDirection = 1;
            }
            else if (movingTo >= PathElements.Length - 1)
            {
                movementDirection = -1;
            }

            movingTo = movingTo + movementDirection;
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}