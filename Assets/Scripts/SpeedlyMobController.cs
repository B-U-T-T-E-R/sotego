using UnityEngine;

public class SpeedlyMobController : EnemyController
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float health = 35;

    void Update()
    {
        Move();
    }
}
