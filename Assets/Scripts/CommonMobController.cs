using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonMobController : EnemyController
{
    public enum MovementType
    {
        Moving,
        Lerping
    }

    public MovementType Type = MovementType.Moving;
    public MovementType MyPath;
    public float speed = 1f;
    public float maxDistance = .1f;

    private IEnumerator<Transform> pointInPath;

    void Start()
    {
        if (MyPath == null)
            return;

        pointInPath = GetNextPathPoint();

        pointInPath.MoveNext();

        if (pointInPath.Current == null)
            return;

        transform.position = pointInPath.Current.position;
    }

    private void Update()
    {
        if(pointInPath == null || pointInPath.Current == null)
            return;

        if(Type == MovementType.Moving)
        {
            transform.position = Vector2.MoveTowards(transform.position, pointInPath.Current.position, Time.deltaTime * speed);
        }
        else if(Type == MovementType.Lerping)
        {
            transform.position = Vector2.Lerp(transform.position, pointInPath.Current.position, Time.deltaTime * speed);
        }

        var distanceSquare = (transform.position - pointInPath.Current.position).sqrMagnitude;
        if(distanceSquare < maxDistance * maxDistance) 
        {
            pointInPath.MoveNext();
        }
    }
}