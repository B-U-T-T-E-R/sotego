using UnityEngine;

public class SpawnMobController : MonoBehaviour
{
    [HideInInspector]
    private int currentCountMobs;
    [HideInInspector]
    private int currentCountWave;
    [HideInInspector]
    private int beforeCountWave;
    [SerializeField]
    private GameObject[] mobs;
    [SerializeField]
    private int maxCountMobs;
    [SerializeField]
    private float percentageAddCountMobs;
    public Transform[] wayPoints;
    private GameObject mob;

    void Start()
    {
        beforeCountWave = currentCountWave = 1;
        percentageAddCountMobs = 0.2f;
    }

    void Update()
    {
        Spawn();
    }

    private void Spawn()
    {
        if(currentCountMobs != maxCountMobs)
        {
            if(currentCountWave <= 10)
            {
                mob = Instantiate(mobs[0]);
            }
            else
            {
                mob = Instantiate(mobs[Random.Range(0, 3)]);
            }
            if(beforeCountWave != currentCountWave)
                percentageAddCountMobs += percentageAddCountMobs;

            mob.GetComponent<CommonMobController>().wayPoints = wayPoints;

            mob.transform.position = new Vector2(-268.1f, 259.4f);

            currentCountMobs++;      
        }
    }

    public float ChangeStatsMob(float health)
    {
        health += health * percentageAddCountMobs;
        return health;
    }
}
