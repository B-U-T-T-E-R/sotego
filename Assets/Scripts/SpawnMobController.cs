using UnityEngine;

public class SpawnMobController : MonoBehaviour
{
    [HideInInspector]
    private int currentCountWave;
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

    void Start() => canSpawn = true;

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

            mob.transform.position = new Vector2(-268.1f, 259.4f);

            currentCountMobsOnWave++;
            canSpawn = false;
        }
    }
    
    public void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("ddd");
        canSpawn = true;
    }
}
