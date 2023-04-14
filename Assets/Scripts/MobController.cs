using System.Collections.Generic;
using UnityEngine;

public class MobController : EnemyController
{
    public float speed = 1f;
    public float maxDistance = .1f;

    private IEnumerator<Transform> pointInPath;

    void Start()
    {

        pointInPath = GetNextPathPoint();

        pointInPath.MoveNext();

        if (pointInPath.Current == null)
            return;

        transform.position = pointInPath.Current.position;
    }

    private void Update()
    {
        if (pointInPath == null || pointInPath.Current == null)
            return;

        transform.position = Vector2.MoveTowards(transform.position, pointInPath.Current.position, Time.deltaTime * speed);

        var distanceSquare = (transform.position - pointInPath.Current.position);
        if (distanceSquare.magnitude < maxDistance)
        {
            pointInPath.MoveNext();
        }
    }
}