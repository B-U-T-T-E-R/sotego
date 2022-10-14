using UnityEngine;
using System.Collections.Generic;
public class EnemyController : MonoBehaviour
{
    public int target = 0;
    public Transform exit;
    public Transform[] wayPoints;
    public float navigation;

    Transform enemy;
    float navigationTime = 0;
    void Start()
    {
        enemy = GetComponent<Transform>();
    }

    public void Move()
    {
        if(wayPoints != null)
        {
            navigationTime += Time.deltaTime;
            if(navigationTime > navigation)
            {
                if(target < wayPoints.Length)
                {
                    enemy.position = Vector2.MoveTowards(enemy.position, wayPoints[target].position, navigationTime);
                }
                else
                {
                    enemy.position = Vector2.MoveTowards(enemy.position, exit.position, navigationTime);
                }
            
                navigationTime = 0;
            }
            
            if(enemy.position == wayPoints[target].position)
                target++;
        }
    }
}
