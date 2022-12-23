using UnityEngine;

public class SpawnMobController : MonoBehaviour
{
    [HideInInspector]
    private int currentCountWave;
    [SerializeField]
    private Vector2 positionSpawn;
    [SerializeField]
    private GameObject[] mobs;
    [SerializeField]
    private bool canSpawn;
    [SerializeField]
    private int maxCountMobs;
    private GameObject mob;
    [HideInInspector]
    public int currentCountMobsOnWave;
    public Transform[] wayPoints;

    void Start()
    { 
        positionSpawn = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        canSpawn = true;
    }

    void Update() => Spawn();

    private void Spawn()
    {
        if(currentCountMobsOnWave != maxCountMobs && canSpawn == true)
        {
            if(currentCountWave <= 10)
            {
                mob = Instantiate(mobs[0]);
            }
            else
            {
                mob = Instantiate(mobs[Random.Range(0, 3)]);
            }

            mob.GetComponent<EnemyController>().wayPoints = wayPoints;

            mob.transform.position = positionSpawn;

            currentCountMobsOnWave++;
            canSpawn = false;
        }

        canSpawn = canSpawnMethod(mob.transform);
    }

    private bool canSpawnMethod(Transform bot)
    {
        if(bot.position.x - 36f >= positionSpawn.x || bot.position.y - 36f >= positionSpawn.y)
            return true;

        return false;
    }
}
