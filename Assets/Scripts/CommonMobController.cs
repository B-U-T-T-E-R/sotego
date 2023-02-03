using UnityEngine;

public class CommonMobController : EnemyController
{
    [SerializeField]
    private Transform mob;

    private void Start()
    {
        mob = GetComponent<Transform>();
    }
    void Update() => Moving(50f, mob);
}