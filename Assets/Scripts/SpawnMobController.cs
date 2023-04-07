using System;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class SpawnMobController : MonoBehaviour
{
    [SerializeField]
    private int currentCountWave;
    [SerializeField]
    private int LastWave;
    [SerializeField]
    private Vector2 positionSpawn;
    [SerializeField]
    private GameObject[] mobs;
    [SerializeField]
    private int maxCountMobs;
    private GameObject mob;
    [HideInInspector]
    public int currentCountMobsOnWave;
    public Transform[] wayPoints;
    private GameObject[] gm;
    private bool isMaxMob;

    int time;
    int time1;

    void Start()
    {
        positionSpawn = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        time = DateTime.Now.Second;
    }

    void Update()
    {
        Spawn();
    }

    private void FixedUpdate()
    {
        gm = GameObject.FindGameObjectsWithTag("Entity");
    }

    private void Spawn()
    {
        if (currentCountMobsOnWave != 5)
            time1 = DateTime.Now.Second;

        if(currentCountMobsOnWave == maxCountMobs)
            isMaxMob = true;

        if (currentCountMobsOnWave != maxCountMobs && time1 - time == 1)
        {
            if (currentCountWave <= 10)
            {
                mob = Instantiate(mobs[0]);
            }
            else
            {
                mob = Instantiate(mobs[UnityEngine.Random.Range(0, 3)]);
            }

            mob.transform.position = positionSpawn;

            currentCountMobsOnWave++;
            time = DateTime.Now.Second;
        }

        if (currentCountMobsOnWave == 0 && isMaxMob)
        {
            LastWave = currentCountWave;
            currentCountWave++;
            isMaxMob = false;
        }

        currentCountMobsOnWave = gm.Length;
    }

    
}
