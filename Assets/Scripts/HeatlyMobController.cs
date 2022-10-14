using UnityEngine;

public class HeatlyMobController : EnemyController
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float health = 75;

    void Update()
    {
        Move();
    }
}
